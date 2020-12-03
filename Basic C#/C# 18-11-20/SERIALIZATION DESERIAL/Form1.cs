using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person per = new Person();
            per.Id = 1;
            per.Name = "Muniba Rasheed";
            per.EmailId = "muniba19@gmail.com";

            MemoryStream ms = new MemoryStream();

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));

            ser.WriteObject(ms, per);

            byte[] jsonArray = ms.ToArray();

            string str = Encoding.UTF8.GetString(jsonArray);
            rtbserialize.Text = str;

        }

        private void btndeserialize_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(rtbserialize.Text));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            Person per = ser.ReadObject(ms) as Person;
            rtbdeserialize.Text = per.Id + " " + per.Name + " " +per.EmailId;
        }
    }
}
