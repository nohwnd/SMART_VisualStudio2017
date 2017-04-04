using System;
using System.Runtime.InteropServices;

namespace Csharp7
{
    public abstract class Component
    {
        public bool IsEnabled { get; set; }
    }

    public class Button : Component
    {
        public string Text { get; set; }

    }

    public class CheckBox : Component
    {
        public void Toggle()
        {
        }
    }


    class PatternMatching
    {
        void OnClick6(Component sender)
        {
            if (sender is Button)
            {
                var button = (Button)sender;
                button.Text = "Clicked";
            }
            else if (sender is CheckBox)
            {
                var checkBox = (CheckBox)sender;
                checkBox.Toggle();
            }
            else
            {
                throw new NotSupportedException();
            }
        }


        void OnClick7WithIf(Component sender)
        {
            if (sender is Button b)
            {
                b.Text = "Clicked";
            }
            else if (sender is CheckBox ch)
            {
                ch.Toggle();
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        void OnClick7WithSwitch(Component sender)
        {
            switch (sender)
            {
                // executed in order (except for default which goes last)
                default:
                    throw new NotSupportedException();

                case Button b:
                    b.Text = "Clicked";
                    break;
                case CheckBox chb when chb.IsEnabled:
                    chb.Toggle();
                    break;
                case CheckBox ch: 
                    //do nothing
                    break;
                
                // cases mean is something && has value
                case null:
                    throw new ArgumentNullException();
            }


            //equivalent to 
            if (sender != null)
            {
                if (sender is Button)
                {

                }
                else if (sender is CheckBox)
                {
                    var ch = sender as CheckBox;
                    if (ch.IsEnabled)
                    {
                        ch.Toggle();
                    }
                    else
                    {
                        // do nothing
                    }
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        // but it is still limited, and very small subset of what was 
        // announced in 2016 was pushed into the released C# 7

    }

}
