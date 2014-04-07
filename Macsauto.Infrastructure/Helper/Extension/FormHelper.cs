using System;
using System.Linq;

namespace Macsauto.Infrastructure.Helper.Extension
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    public static class FormHelper
    {
        public static void EnableAll(this Control.ControlCollection controlCollection)
        {
            ChangeState(controlCollection, true);
        }

        public static void DisableAll(this Control.ControlCollection controlCollection)
        {
            ChangeState(controlCollection, false);
        }

        private static void ChangeState(Control.ControlCollection controlCollection, bool state)
        {
            foreach (var control in controlCollection)
            {
                if (control is TextBox)
                {
                    var txtControl = control as TextBox;

                    txtControl.ReadOnly = !state;
                }
                else if (control is ComboBox)
                {
                    var cboControl = control as ComboBox;

                    cboControl.Enabled = state;
                }
            }
        }

        public static void ClearContent(this Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                if (control.HasChildren)
                {
                    control.Controls.ClearContent();
                }
                else
                {
                    if (control is TextBox)
                    {
                        var txtControl = control as TextBox;

                        if (!txtControl.ReadOnly)
                        {
                            txtControl.Text = string.Empty;
                        }
                    }
                    else if (control is ComboBox)
                    {
                        var cboControl = control as ComboBox;

                        cboControl.SelectedIndex = -1;
                        cboControl.Items.Clear();
                    }
                }   
            }
        }

        public static void ShowError(this Control control, string errorMsg)
        {
            MessageBox.Show(errorMsg, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            control.Focus();
        }

        public static bool ValidateInput(this Control.ControlCollection controlCollection, ErrorProvider errorProvider)
        {
            return controlCollection.Cast<Control>().Aggregate(true, (current, control) => ValidateInputValue(control, errorProvider, current));
        }

        public static bool ValidateInput(this Control[] controls, ErrorProvider errorProvider)
        {
            return controls.Aggregate(true, (current, control) => ValidateInputValue(control, errorProvider, current));
        }

        private static bool ValidateInputValue(Control control, ErrorProvider errorProvider, bool isPassed)
        {
            if (control is TextBox)
            {
                var txtControl = control as TextBox;

                if (string.IsNullOrEmpty(txtControl.Text))
                {
                    errorProvider.SetError(txtControl, txtControl.Name.Substring(3) + " is required");

                    txtControl.Focus();

                    isPassed = false;
                }
            }
            else if (control is ComboBox)
            {
                var cboControl = control as ComboBox;

                if (cboControl.SelectedItem == null)
                {
                    errorProvider.SetError(cboControl, cboControl.Name.Substring(3) + " is required");

                    isPassed = false;
                }
            }

            return isPassed;
        }
    }
}