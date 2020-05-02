using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;

namespace ItemCreator
{
    public partial class ItemCreator : Form
    {
        public ItemCreator()
        {
            InitializeComponent();
        }

        JArray items = new JArray();
        const string path = "items.json";

        private void ItemCreator_Load(object sender, EventArgs e)
        { 
            if (File.Exists(path))
            {
                items = JArray.Parse(File.ReadAllText(path));
                foreach (JToken item in items)
                {
                    dataGridView1.Rows.Add(item["name"], item["isIllegal"], item["multiplier"]);
                }
            }
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            { MessageBox.Show("Please give a Name for your item."); }
            else
            {
                string name = tb_Name.Text;
                bool isIllegal = true;
                if (rb_True.Checked)
                { isIllegal = true; }
                else if (rb_False.Checked)
                { isIllegal = false; }
                int multiplier = Convert.ToInt32(num_Multiplier.Value);

                AddItemJson(name, isIllegal, multiplier);
                AddItemGridView(name, isIllegal, multiplier);
            }
        }

        private void AddItemJson(string name, bool isIllegal, int multiplier)
        {
            JObject tempObject = new JObject();
            tempObject.Add("name", name);
            tempObject.Add("isIllegal", isIllegal);
            tempObject.Add("multiplier", multiplier);
            items.Add(tempObject);
            File.WriteAllText(path, items.ToString());
        }

        private void AddItemGridView(string name, bool isIllegal, int multiplier) => dataGridView1.Rows.Add(name, isIllegal, multiplier);
    }
}
