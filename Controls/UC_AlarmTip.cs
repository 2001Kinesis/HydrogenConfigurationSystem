using System;
using System.Windows.Forms;
using System.Drawing;

namespace Custom.HydrogenConfigurationSystem.Controls
{
    public partial class UC_AlarmTip : UserControl
    {
        private System.Windows.Forms.Timer? _blinkTimer;
        private bool _isBlinking = false;
        private bool _isVisible = true;

        public UC_AlarmTip()
        {
            InitializeComponent();
            InitializeBlinkTimer();
        }

        private void InitializeBlinkTimer()
        {
            _blinkTimer = new System.Windows.Forms.Timer();
            _blinkTimer.Interval = 500;
            _blinkTimer.Tick += BlinkTimer_Tick;
        }

        public string AlarmMessage
        {
            get => lblAlarmMessage.Text;
            set => lblAlarmMessage.Text = value;
        }

        public void StartBlinking()
        {
            if (_blinkTimer != null && !_isBlinking)
            {
                _isBlinking = true;
                _blinkTimer.Start();
                this.BackColor = Color.FromArgb(64, 0, 0);
                lblAlarmMessage.ForeColor = Color.Red;
            }
        }

        public void StopBlinking()
        {
            if (_blinkTimer != null && _isBlinking)
            {
                _isBlinking = false;
                _blinkTimer.Stop();
                this.BackColor = Color.FromArgb(15, 23, 42);
                lblAlarmMessage.ForeColor = Color.FromArgb(34, 197, 94);
                lblAlarmMessage.Visible = true;
                _isVisible = true;
            }
        }

        private void BlinkTimer_Tick(object? sender, EventArgs e)
        {
            _isVisible = !_isVisible;
            lblAlarmMessage.Visible = _isVisible;
        }
    }
}
