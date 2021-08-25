using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Demo_serialization_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<User> users = new List<User>();

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                firstname = textBox1.Text,
                lastname = textBox2.Text,
                BirthDate = dateTimePicker1.Value
            };
            //Adds the user to the collection
            users.Add(user);
            //Refershes the data source of our userslist
            UserListBox.DataSource = null;
            UserListBox.DataSource = users;
        }
        private void serialize()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(users.GetType());

                using (StreamWriter sw = new StreamWriter("users.Xml"))
                {
                    serializer.Serialize(sw, users);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialize();
        }
        private void Deserialize()
        {
            try
            {
                if (File.Exists("users.Xml"))
                {
                    XmlSerializer serialize = new XmlSerializer(users.GetType());
                    using (StreamReader sr = new StreamReader("users.Xml"))
                    {
                        users = (List<User>)serialize.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException("File not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deserialize();
            UserListBox.DataSource = users;

        }
    }
}


    


