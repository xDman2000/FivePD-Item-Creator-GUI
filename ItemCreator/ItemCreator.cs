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
        private enum Occurance
        {
            Vehicles = 0,
            Peds = 1,
            Both = 2
        }

        public ItemCreator()
        {
            InitializeComponent();

            cb_Occurance.DataSource = Enum.GetValues(typeof(Occurance));
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
                    dataGridView1.Rows.Add(item["name"], item["isIllegal"], (Occurance)Convert.ToInt32(item["itemLocation"]), item["multiplier"]);
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
                if (rb_IllegalTrue.Checked)
                { isIllegal = true; }
                else if (rb_IllegalFalse.Checked)
                { isIllegal = false; }

                Occurance enumOccurance = (Occurance)cb_Occurance.SelectedValue;
                int occurance = (int)enumOccurance;

                int multiplier = Convert.ToInt32(num_Multiplier.Value);

                AddItemJson(name, isIllegal, occurance, multiplier);
                AddItemGridView(name, isIllegal, occurance, multiplier);
            }
        }

        private void AddItemJson(string name, bool isIllegal, int occurance, int multiplier)
        {
            JObject tempObject = new JObject();
            tempObject.Add("name", name);
            tempObject.Add("isIllegal", isIllegal);
            tempObject.Add("itemLocation", occurance);
            tempObject.Add("multiplier", multiplier);
            items.Add(tempObject);
            File.WriteAllText(path, items.ToString());
        }

        private void AddItemGridView(string name, bool isIllegal, int occurance, int multiplier) => dataGridView1.Rows.Add(name, isIllegal, (Occurance)occurance, multiplier);
    }
}
