using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using BusPirate;
using System.IO;

namespace BusPirate
{
	public partial class BPConsole : Form
	{
		BPPort bpPort = null;
		private bool script_changed = false;

		public BPConsole()
		{
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			ComPortRefresh();
		}

		private void ComPortRefresh()
		{
			string selected = ComPort.SelectedItem as string ?? "COM2";
			ComPort.Items.Clear();
			SortedList<string, string> ports = new SortedList<string, string>();
			foreach (string port in SerialPort.GetPortNames())
				ports.Add(port.ToUpper(), port);

			foreach(string port in ports.Keys)
			{
				ComPort.Items.Add(port);
				if (port == selected)
					ComPort.SelectedIndex = ComPort.Items.Count - 1;
			}
		}

		private void Connect_Click(object sender, EventArgs e)
		{
			if (bpPort == null)
			{
				if (ComPort.SelectedIndex >= 0)
				{
					string port = ComPort.SelectedItem as string;
					bpPort = new BPPort(port);
					bpPort.WaitResponse += new BPPort.WaitResponseEventHandle(bpPort_WaitResponse);
					bpPort.RecieveData += new BPPort.RecieveDataEventHandle(bpPort_RecieveData);
					bpPort.SendStarted += new BPPort.SendStartedEventHandle(bpPort_SendStarted);
					bpPort.SendEnded += new BPPort.SendEndedEventHandle(bpPort_SendEnded);
					try
					{
						if (bpPort.Connect() == BP_RESPONSE.OK)
						{
							Connect.Text = "F8 - Disconnect";
							groupCommand.Enabled = groupMode.Enabled = true;
							Mode.SelectedIndex = ((int)bpPort.Mode) - 1;
							StatusText(bpPort.FirmwareVersion);
							if (bpPort.Info() == BP_RESPONSE.OK)
								DisplayPins();

							TimerStart();
							return;
						}
						else
						{
							StatusText("BusPirate not found");
						}
					}
					catch (Exception ex)
					{
						LogError(ex.Message);
					}
				}
			}
			else
			{
				timer.Stop();
				Connect.Text = "F8 - Connect";
				groupCommand.Enabled = groupMode.Enabled = false;
				bpPort.Disconnect();
				bpPort = null;
			}
		}

		private void TimerStart()
		{
			if (AutoInfo.Checked == true)
			{
				timer.Interval = (int)Interval.Value;
				timer.Start();
			}
		}
		private void TimerStop()
		{
			timer.Stop();
		}

		private void AutoInfo_CheckedChanged(object sender, EventArgs e)
		{
			TimerStart();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			TimerStop();
			if (AutoInfo.Checked && bpPort != null && bpPort.IsConnected)
			{
				if (InvokeRequired)
				{
					try
					{
						BeginInvoke(new MethodInvoker(delegate()
							{
								timer_Tick(sender, e);
							}));
					}
					catch { }
				}
				else
					RefreshVoltage();
			}
		}

		void bpPort_SendStarted(object sender, string data)
		{
			timer.Stop();
		}

		void bpPort_SendEnded(object sender, string data)
		{
			TimerStart();
		}

		void bpPort_RecieveData(object sender, string data)
		{
			AppendLog(data);
		}

		private void AppendLog(string data)
		{
			if (string.IsNullOrEmpty(data))
				return;

			if (this.InvokeRequired)
			{
				this.BeginInvoke(new Action<string>(AppendLog), data);
			}
			else
			{
				Log.SuspendLayout();
				if (Log.Text.Length > 4000)
					Log.Text = Log.Text.Substring(Log.Text.Length - 4000) + data;
				else
					Log.Text += data;
				Log.SelectionStart = Log.Text.Length;
				Log.ScrollToCaret();
				Log.ResumeLayout(false);
			}
		}

		void bpPort_WaitResponse(object sender)
		{
			Application.DoEvents();
		}

		private void LogError(string msg)
		{
			MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void Mode_SelectedIndexChanged(object sender, EventArgs e)
		{
			groupI2C.Visible = groupUART.Visible = groupSPI.Visible = group2WIRE.Visible = group3WIRE.Visible = false;

			string mode = Mode.SelectedItem as string;
			switch (mode)
			{
				case "HiZ":
					break;
				case "I2C":
					groupI2C.Visible = true;
					break;
				case "UART":
					groupUART.Visible = true;
					break;
				case "SPI":
					groupSPI.Visible = true;
					break;
				case "2WIRE":
					group2WIRE.Visible = true;
					break;
				case "3WIRE":
					group3WIRE.Visible = true;
					break;
			}
		}

		private void SetMode_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
			{
				ClearSatus();
				string mode = Mode.SelectedItem as string;
				switch (mode)
				{
					case "HiZ":
						DisplayStatus(bpPort.ModeHiZ());
						break;
					case "1-WIRE":
						DisplayStatus(bpPort.ModeWIRE1());
						break;
					case "UART":
						{
							BP_UART_SPEED speed = BP_UART_SPEED.BPS_115200;
							if (cbUART300.Checked)
								speed = BP_UART_SPEED.BPS_300;
							else if (cbUart1200.Checked)
								speed = BP_UART_SPEED.BPS_1200;
							else if (cbUart2400.Checked)
								speed = BP_UART_SPEED.BPS_2400;
							else if (cbUart4800.Checked)
								speed = BP_UART_SPEED.BPS_4800;
							else if (cbUart9600.Checked)
								speed = BP_UART_SPEED.BPS_9600;
							else if (cbUart19200.Checked)
								speed = BP_UART_SPEED.BPS_19200;
							else if (cbUart38400.Checked)
								speed = BP_UART_SPEED.BPS_38400;
							else if (cbUart57600.Checked)
								speed = BP_UART_SPEED.BPS_57600;
							else if (cbUart115200.Checked)
								speed = BP_UART_SPEED.BPS_115200;

							BP_UART_PROTOCOL protocol = BP_UART_PROTOCOL.Data_8_None;
							if (cbUart8Even.Checked)
								protocol = BP_UART_PROTOCOL.Data_8_Even;
							else if(cbUart8None.Checked)
								protocol = BP_UART_PROTOCOL.Data_8_None;
							else if (cbUart8Odd.Checked)
								protocol = BP_UART_PROTOCOL.Data_8_Odd;
							else if (cbUart9None.Checked)
								protocol = BP_UART_PROTOCOL.Data_9_None;

							BP_UART_STOP stop = cbUartStop2.Checked ? BP_UART_STOP.Stop_2 : BP_UART_STOP .Stop_1;
							BP_UART_POLARITY polarity = cbUartIdle0.Checked ? BP_UART_POLARITY.Idle_0 : BP_UART_POLARITY.Idle_1;
							BP_OUTPUT output = cbUartOutOC.Checked ? BP_OUTPUT.OpenDrain : BP_OUTPUT.Normal;

							DisplayStatus(bpPort.ModeUART(speed, protocol, stop, polarity, output));
						}
						break;
					case "I2C":
						{
							BP_I2C_SPEED speed = BP_I2C_SPEED.I2C_100KHz;
							if (cbI2C5.Checked)
								speed = BP_I2C_SPEED.I2C_5KHz;
							else if (cbI2C50.Checked)
								speed = BP_I2C_SPEED.I2C_50KHz;
							else if (cbI2C100.Checked)
								speed = BP_I2C_SPEED.I2C_100KHz;
							else
								speed = BP_I2C_SPEED.I2C_400KHz;
							DisplayStatus(bpPort.ModeI2C(speed));
						}
						break;
					case "SPI":
						{
							BP_SPI_SPEED speed = BP_SPI_SPEED.Speed_125KHz;
							if (cbSpi30.Checked)
								speed = BP_SPI_SPEED.Speed_30KHz;
							else if (cbSpi125.Checked)
								speed = BP_SPI_SPEED.Speed_125KHz;
							else if (cbSpi250.Checked)
								speed = BP_SPI_SPEED.Speed_250KHz;
							else if(cbSpi1000.Checked)
								speed = BP_SPI_SPEED.Speed_1MHz;

							BP_SPI_CLOCK_POLARITY polarity = cbSpiPolarityLow.Checked ? BP_SPI_CLOCK_POLARITY.Low : BP_SPI_CLOCK_POLARITY.High;
							BP_SPI_CLOCK_EDGE edge = cbSpiEdgeIdle.Checked ? BP_SPI_CLOCK_EDGE.Idle : BP_SPI_CLOCK_EDGE.Active;
							BP_SPI_INPUT_PHASE phase = cbSpiInputMiddle.Checked ? BP_SPI_INPUT_PHASE.Middle : BP_SPI_INPUT_PHASE.End;
							BP_CS_POLARITY cs = cbSpiCsPositive.Checked ? BP_CS_POLARITY.Positive : BP_CS_POLARITY.Negative;
							BP_OUTPUT output = cbSpiOutOC.Checked ? BP_OUTPUT.OpenDrain : BP_OUTPUT.Normal;
							DisplayStatus(bpPort.ModeSPI(speed, polarity, edge, phase, cs, output));
						}
						break;
					case "2WIRE":
						{
							BP_WIRE_SPEED speed = BP_WIRE_SPEED.Speed_5KHz;
							if (cb2W5.Checked)
								speed = BP_WIRE_SPEED.Speed_5KHz;
							else if (cb2W50.Checked)
								speed = BP_WIRE_SPEED.Speed_50KHz;
							else if (cb2W100.Checked)
								speed = BP_WIRE_SPEED.Speed_100KHz;
							else
								speed = BP_WIRE_SPEED.Speed_400KHz;
							BP_OUTPUT output = cb2WOutOC.Checked ? BP_OUTPUT.OpenDrain : BP_OUTPUT.Normal;
							DisplayStatus(bpPort.ModeWIRE2(speed, output));
						}
						break;
					case "3WIRE":
						{
							BP_WIRE_SPEED speed = BP_WIRE_SPEED.Speed_5KHz;
							if (cb3W5.Checked)
								speed = BP_WIRE_SPEED.Speed_5KHz;
							else if (cb3W50.Checked)
								speed = BP_WIRE_SPEED.Speed_50KHz;
							else if (cb3W100.Checked)
								speed = BP_WIRE_SPEED.Speed_100KHz;
							else
								speed = BP_WIRE_SPEED.Speed_400KHz;
							BP_CS_POLARITY cs = cb3WCsPositive.Checked ? BP_CS_POLARITY.Positive : BP_CS_POLARITY.Negative;
							BP_OUTPUT output = cb3WOutOC.Checked ? BP_OUTPUT.OpenDrain : BP_OUTPUT.Normal;
							DisplayStatus(bpPort.ModeWIRE3(speed, cs, output));
						}
						break;
					case "LCD":
						DisplayStatus(bpPort.ModeLCD());
						break;
					case "DIO":
						DisplayStatus(bpPort.ModeDIO());
						break;
				}
			}
		}

		private void ClearSatus()
		{
			StatusText("");
		}

		private void DisplayStatus(BP_RESPONSE response)
		{
			StatusText(response.ToString());
			if (AutoInfo.Checked)
				RefreshVoltage();
		}

		private void StatusText(string text)
		{
			if (this.InvokeRequired)
				this.BeginInvoke(new Action<string>(StatusText), new object[] { text });
			else
			{
				Status.Text = text;
			}
		}

		private void RefreshVoltage()
		{
			if(bpPort != null)
			{
				bool log = bpPort.EnableRecieveData;
				bpPort.EnableRecieveData = false;
				if(bpPort.Voltage() == BP_RESPONSE.OK)
					DisplayPins();
				bpPort.EnableRecieveData = log;
			}
		}
		private void DisplayPins()
		{
			if (bpPort != null)
			{
				DisplayPin(name10, mode10, value10, bpPort.Pins[9]);
				DisplayPin(name9, mode9, value9, bpPort.Pins[8]);
				DisplayPin(name8, mode8, value8, bpPort.Pins[7]);
				DisplayPin(name7, mode7, value7, bpPort.Pins[6]);
				DisplayPin(name6, mode6, value6, bpPort.Pins[5]);
				DisplayPin(name5, null, value5, bpPort.Pins[4]);
				DisplayPin(name4, null, value4, bpPort.Pins[3]);
				DisplayPin(name3, null, value3, bpPort.Pins[2]);
				DisplayPin(name2, null, value2, bpPort.Pins[1]);
			}
		}

		private void AuxLow_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.AuxLow());
		}

		private void AuxHigh_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.AuxHigh());
		}

		private void AuxRead_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.AuxRead());
		}

		private void Delay_uS_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.Delay_mS((int)Delay.Value));
		}

		private void Delay_mS_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.Delay_uS((int)Delay.Value));
		}

		private void PowerOff_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.PowerOff());
		}

		private void PowerOn_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.PowerOn());
		}

		private void Voltage_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.Voltage());
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.Reset());
		}

		private void Info_Click(object sender, EventArgs e)
		{
			if (bpPort != null)
				DisplayStatus(bpPort.Info());
		}

		private void DisplayPin(Label name, Label mode, Label value, Pin pin)
		{
			name.Text = pin.Name;
			if (pin.Type == BP_PIN_TYPE.Analog || pin.Type == BP_PIN_TYPE.Power)
			{
				value.Text = string.Format("{0:0.00}", pin.Analog);
			}
			else if (pin.Type == BP_PIN_TYPE.Input)
			{
				mode.Text = "I";
				mode.BackColor = Color.FromArgb(64, 64, 192);
				mode.ForeColor = Color.White;
			}
			else if (pin.Type == BP_PIN_TYPE.Output)
			{
				mode.Text = "O";
				mode.BackColor = Color.FromArgb(192, 64, 64);
				mode.ForeColor = Color.White;
			}
			if (pin.Type == BP_PIN_TYPE.Input || pin.Type == BP_PIN_TYPE.Output)
			{
				if (pin.Digital)
				{
					value.Text = "HIGH";
					value.BackColor = Color.FromArgb(0, 208, 0);
				}
				else
				{
					value.Text = "LOW";
					value.BackColor = Color.FromArgb(208, 208, 0);
				}
			}
		}

		private void Run_Click(object sender, EventArgs e)
		{
			BP_RESPONSE response = BP_RESPONSE.Disconnect;
			if (bpPort != null && bpPort.IsConnected)
			{
				string script = Script.Text.Trim();
				foreach (string line in script.Split(new char[] { '\r', '\n' }))
				{
					string cmd = line.Trim();
					if (!string.IsNullOrEmpty(cmd))
					{
						int idx = cmd.IndexOf("//");
						if (idx >= 0)
							cmd = cmd.Substring(0, idx).Trim();
						foreach (string subline in cmd.Split(new char[] { '\'' }))
						{
							string subcmd = subline.Trim();
							if (!string.IsNullOrEmpty(subcmd))
							{
								response = bpPort.SendWait(subcmd);
								if (response != BP_RESPONSE.OK)
									break;
							}
						}
					}
				}
			}
			DisplayStatus(response);
		}

		private void Browse_Click(object sender, EventArgs e)
		{
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				FileName.Text = openDialog.FileName;
				OpenFile(false);
			}
		}

		private void Open_Click(object sender, EventArgs e)
		{
			OpenFile(true);
		}

		private void OpenFile(bool can_browse)
		{
			if (script_changed)
			{
				if (MessageBox.Show("Script changed, save before load ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					Save_Click(null, EventArgs.Empty);
					return;
				}
				script_changed = false;
			}

			string filename = FileName.Text.Trim();

			if (string.IsNullOrEmpty(filename))
			{
				if (can_browse)
					Browse_Click(null, EventArgs.Empty);
			}
			else
			{
				if (File.Exists(filename))
				{
					using (StreamReader reader = new StreamReader(filename))
					{
						Script.Text = reader.ReadToEnd();
						Script.Select(0, 0);
						reader.Close();
					}
					script_changed = false;
				}
			}
		}

		private void Script_TextChanged(object sender, EventArgs e)
		{
			script_changed = true;
		}

		private void Save_Click(object sender, EventArgs e)
		{
			string filename = FileName.Text.Trim();
			if (!string.IsNullOrEmpty(filename))
				saveDialog.FileName = filename;
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				filename = FileName.Text = saveDialog.FileName;
				using (StreamWriter writer = new StreamWriter(filename))
				{
					writer.Write(Script.Text.Trim());
					writer.Close();
				}
				script_changed = false;
			}
		}

		private void Tab_Click(object sender, EventArgs e)
		{
			int start = Script.SelectionStart;
			Script.Text = Script.Text.Substring(0, start) + "\t" + Script.Text.Substring(start + Script.SelectionLength);
			Script.SelectionStart = start + 1;
			Script.Focus();
		}

		private void ClearLog_Click(object sender, EventArgs e)
		{
			Log.Text = "";
		}

		private void Log_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (c != '\t')
			{
				TimerStop();
				if (bpPort != null)
					bpPort.Send(c);
				if (c == '\r')
					TimerStart();

				e.Handled = true;
			}
		}

		private void BPConsole_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F2:
					Open_Click(sender, EventArgs.Empty);
					e.Handled = true;
					break;
				case Keys.F3:
					Save_Click(sender, EventArgs.Empty);
					e.Handled = true;
					break;
				case Keys.F8:
					Connect_Click(sender, EventArgs.Empty);
					e.Handled = true;
					break;
				case Keys.F5:
						Run_Click(sender, EventArgs.Empty);
						e.Handled = true;
						break;
			}
		}
	}
}
