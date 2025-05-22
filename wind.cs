using System;
using System.Threading;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting to spawn windows...");

        for (int i = 0; i < 99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999; i++) //For safety purposes <3
        {
            Thread t = new Thread(() =>
            {
                Application.Run(new MyForm());
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            Thread.Sleep(0); 
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public class MyForm : Form
    {
        public MyForm()
        {
            this.Text = "Window";
            this.Width = 300;
            this.Height = 200;
            Label label = new Label()
            {
                Text = "New Thread Window",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            this.Controls.Add(label);
        }
    }
}
