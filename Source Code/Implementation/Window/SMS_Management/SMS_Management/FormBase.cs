using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS_Management.Database;

namespace SMS_Management
{
    public class FormBase : Form
    {
        private FormStateType _state;
        public FormStateType FormState
        {
            get { return _state; }
            set { _state = value; }
        }
        public FormBase()
        {
            _state = FormStateType.Normal;
        }

        public enum FormStateType
        {
            Normal,
            New,
            Edit
        }

    }

}
