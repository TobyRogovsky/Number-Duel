using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace NumberDuelSystem
{
    public class Btns : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private bool _enabled;
        private bool _easywin;
        private Color _backcolor;

        public int Num {  get; set; }
        public bool Enabled
        {
            get => _enabled; set
            {
                _enabled = value;
                InvokePropertyChanged();
            }
        }       

        public bool EasyWin
        {
            get => _easywin;set
            {
                _easywin = value;
                InvokePropertyChanged();
            }
        }
        public System.Drawing.Color BackColor
        {
            get => _backcolor;set
            {
                _backcolor = value;
                InvokePropertyChanged();
                InvokePropertyChanged("BackColorMaui");
            }
        }
        public Microsoft.Maui.Graphics.Color BackColorMaui
        {
            get => this.ConvertToMauiColor(this.BackColor);
        }

        public void Clear()
        {
            Enabled = true;
            EasyWin = false;
        }
        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        private Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;
            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }
    }
}
