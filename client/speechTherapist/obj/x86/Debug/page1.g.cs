﻿#pragma checksum "C:\Users\יגודייב\Desktop\תכנות סופי\p2\speechTherapist\page1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8582CD7277930C9FB3FF0F0AF44364F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace speechTherapist
{
    partial class page1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // page1.xaml line 17
                {
                    this.tblok1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // page1.xaml line 18
                {
                    this.cview = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                }
                break;
            case 4: // page1.xaml line 19
                {
                    global::Windows.UI.Xaml.Controls.CalendarViewDayItem element4 = (global::Windows.UI.Xaml.Controls.CalendarViewDayItem)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarViewDayItem)element4).Tapped += this.CalendarViewDayItem_Tapped;
                }
                break;
            case 5: // page1.xaml line 20
                {
                    this.btn1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn1).Click += this.btn1_Click;
                }
                break;
            case 6: // page1.xaml line 21
                {
                    this.tbox1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // page1.xaml line 22
                {
                    this.p1 = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 8: // page1.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element8 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element8).Click += this.AppBarButton_Click;
                }
                break;
            case 9: // page1.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element9).Click += this.AppBarButton_Click_1;
                }
                break;
            case 10: // page1.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Button_Click;
                }
                break;
            case 11: // page1.xaml line 28
                {
                    this.tBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // page1.xaml line 29
                {
                    this.lView1 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

