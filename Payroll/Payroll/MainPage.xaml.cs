using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Payroll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            double HW = Double.Parse(HoursWorked.Text);
            double Rph = 0;
            double Basic = 0;
            double Overtime = 0;
            double wtax = 0;
            double Philhealth = 0;
            double Pagibig = 0;
            double GI = 0;
            double Deduction = 0;
            double NI = 0;
            String ES = EmploymentStatus.Text;
            String CS = CivilStatus.Text;


            switch(ES)
            {
                case "R":
                    if (HW <= 120)
                    {
                        Rph = 800 / 8;
                        Basic = HW * Rph;
                        GI = Basic;
                    }
                    else 
                    {
                        Rph = 800 / 8;
                        Basic = 120 * Rph;
                        Overtime = (1.5 * Rph) * (HW - 120);
                        GI = Basic + Overtime;
                    }
                    break;

                case "P":
                    if (HW <= 120)
                    {
                        Rph = 600 / 8;
                        Basic = HW * Rph;
                        GI = Basic;
                    }
                    else 
                    {
                        Rph = 600 / 8;
                        Basic = 120 * Rph;
                        Overtime = (1.5 * Rph) * (HW - 120);
                        GI = Basic + Overtime;
                    }
                    break;

                case "C":
                    if (HW <= 120)
                    {
                        Rph = 500 / 8;
                        Basic = HW * Rph;
                        GI = Basic;
                    }
                    else
                    {
                        Rph = 500 / 8;
                        Basic = 120 * Rph;
                        Overtime = (1.5 * Rph) * (HW - 120);
                        GI = Basic + Overtime;
                    }
                    break;

                case "T":
                    if (HW <= 120)
                    {
                        Rph = 450 / 8;
                        Basic = HW * Rph;
                        GI = Basic;
                    }
                    else
                    {
                        Rph = 450 / 8;
                        Basic = 120 * Rph;
                        Overtime = (1.5 * Rph) * (HW - 120);
                        GI = Basic + Overtime;
                    }
                    break;

                default:
                    if (HW <= 120)
                    {
                        Rph = 400 / 8;
                        Basic = HW * Rph;
                        GI = Basic;
                    }
                    else
                    {
                        Rph = 400 / 8;
                        Basic = 120 * Rph;
                        Overtime = (1.5 * Rph) * (HW - 120);
                        GI = Basic + Overtime;
                    }
                    break;
            
            }


            switch (CS)
            {
                case "S":
                    if (GI > 10000)
                    {
                        wtax = GI * 0.10;
                        Pagibig = GI * 0.05;
                    }
                    else if (GI > 5000)
                    {
                        wtax = GI * 0.08;
                        Pagibig = GI * 0.03;
                    }
                    else
                    {
                        wtax = GI * 0.05;
                        Pagibig = GI * 0.02;
                    }

                    Philhealth = 500;

                    break;

                case "M":
                    if (GI > 10000)
                    {
                        wtax = GI * 0.10;
                        Pagibig = GI * 0.05;
                    }
                    else if (GI > 5000)
                    {
                        wtax = GI * 0.08;
                        Pagibig = GI * 0.03;
                    }
                    else
                    {
                        wtax = GI * 0.05;
                        Pagibig = GI * 0.02;
                    }

                    Philhealth = 300;

                    break;

                default:
                    if (GI > 10000)
                    {
                        wtax = GI * 0.10;
                        Pagibig = GI * 0.05;
                    }
                    else if (GI > 5000)
                    {
                        wtax = GI * 0.08;
                        Pagibig = GI * 0.03;
                    }
                    else
                    {
                        wtax = GI * 0.05;
                        Pagibig = GI * 0.02;
                    }

                    Philhealth = 400;

                    break;
            }

            Deduction = wtax + Philhealth + Pagibig;
            NI = GI - Deduction;


            Application.Current.Properties["GrossIncome"] = GI;
            Application.Current.Properties["Deduction"] = Deduction;
            Application.Current.Properties["NetIncome"] = NI;
            Navigation.PushAsync(new Page1());

        }
    }
}
