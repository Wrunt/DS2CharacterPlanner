using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace DS2_Character_Planner
{
    public partial class Form1 : Form
    {
        List<Stats> listat = new List<Stats>();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
            ClearModel();
        }

        private void comClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comClass.SelectedIndex > 0)
            {
                UpdateText();

                save.Enabled = true;
                check.Enabled = true;
                reset.Enabled = true;
                update.Enabled = true;
            }
            else
            {
                save.Enabled = false;
                check.Enabled = false;
                reset.Enabled = false;
                update.Enabled = false;
            }
        }

        private void UpdateModel(TextBox tb1, TextBox tb2, TextBox tb3)
        {
            if (!string.IsNullOrEmpty(tb3.Text))
            {
                if (Int32.Parse(tb3.Text) - 1 < Int32.Parse(tb1.Text) || Int32.Parse(tb3.Text) > Int32.Parse(tb1.Text))
                {
                    
                    List<Stats> holder = new List<Stats>();
                    foreach (Stats stat in listat)
                    {
                        switch (tb1.Name)
                        {
                            case "vig1":
                                if (Int32.Parse(stat.VigorBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.VigorNew = stat.VigorBase;
                                    stat.VigorDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.VigorNew = "99";
                                    stat.VigorDiff = (99 - Int32.Parse(stat.VigorBase)).ToString();
                                }
                                else
                                {
                                    stat.VigorNew = tb3.Text;
                                    stat.VigorDiff = (Int32.Parse(stat.VigorNew) - Int32.Parse(stat.VigorBase)).ToString();
                                }
                                break;
                            case "end1":
                                if (Int32.Parse(stat.EnduranceBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.EnduranceNew = stat.EnduranceBase;
                                    stat.EnduranceDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.EnduranceNew = "99";
                                    stat.EnduranceDiff = (99 - Int32.Parse(stat.EnduranceBase)).ToString();
                                }
                                else
                                {
                                    stat.EnduranceNew = tb3.Text;
                                    stat.EnduranceDiff = (Int32.Parse(stat.EnduranceNew) - Int32.Parse(stat.EnduranceBase)).ToString();
                                }
                                break;
                            case "vit1":
                                if (Int32.Parse(stat.VitalityBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.VitalityNew = stat.VitalityBase;
                                    stat.VitalityDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.VitalityNew = "99";
                                    stat.VitalityDiff = (99 - Int32.Parse(stat.VitalityBase)).ToString();
                                }
                                else
                                {
                                    stat.VitalityNew = tb3.Text;
                                    stat.VitalityDiff = (Int32.Parse(stat.VitalityNew) - Int32.Parse(stat.VitalityBase)).ToString();
                                }
                                break;
                            case "att1":
                                if (Int32.Parse(stat.AttunementBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.AttunementNew = stat.AttunementBase;
                                    stat.AttunementDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.AttunementNew = "99";
                                    stat.AttunementDiff = (99 - Int32.Parse(stat.AttunementBase)).ToString();
                                }
                                else
                                {
                                    stat.AttunementNew = tb3.Text;
                                    stat.AttunementDiff = (Int32.Parse(stat.AttunementNew) - Int32.Parse(stat.AttunementBase)).ToString();
                                }
                                break;
                            case "str1":
                                if (Int32.Parse(stat.StrengthBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.StrengthNew = stat.StrengthBase;
                                    stat.StrengthDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.StrengthNew = "99";
                                    stat.StrengthDiff = (99 - Int32.Parse(stat.StrengthBase)).ToString();
                                }
                                else
                                {
                                    stat.StrengthNew = tb3.Text;
                                    stat.StrengthDiff = (Int32.Parse(stat.StrengthNew) - Int32.Parse(stat.StrengthBase)).ToString();
                                }
                                break;
                            case "dex1":
                                if (Int32.Parse(stat.DexterityBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.DexterityNew = stat.DexterityBase;
                                    stat.DexterityDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.DexterityNew = "99";
                                    stat.DexterityDiff = (99 - Int32.Parse(stat.DexterityBase)).ToString();
                                }
                                else
                                {
                                    stat.DexterityNew = tb3.Text;
                                    stat.DexterityDiff = (Int32.Parse(stat.DexterityNew) - Int32.Parse(stat.DexterityBase)).ToString();
                                }
                                break;
                            case "ada1":
                                if (Int32.Parse(stat.AdaptabilityBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.AdaptabilityNew = stat.AdaptabilityBase;
                                    stat.AdaptabilityDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.AdaptabilityNew = "99";
                                    stat.AdaptabilityDiff = (99 - Int32.Parse(stat.AdaptabilityBase)).ToString();
                                }
                                else
                                {
                                    stat.AdaptabilityNew = tb3.Text;
                                    stat.AdaptabilityDiff = (Int32.Parse(stat.AdaptabilityNew) - Int32.Parse(stat.AdaptabilityBase)).ToString();
                                }
                                break;
                            case "int1":
                                if (Int32.Parse(stat.IntelligenceBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.IntelligenceNew = stat.IntelligenceBase;
                                    stat.IntelligenceDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.IntelligenceNew = "99";
                                    stat.IntelligenceDiff = (99 - Int32.Parse(stat.IntelligenceBase)).ToString();
                                }
                                else
                                {
                                    stat.IntelligenceNew = tb3.Text;
                                    stat.IntelligenceDiff = (Int32.Parse(stat.IntelligenceNew) - Int32.Parse(stat.IntelligenceBase)).ToString();
                                }
                                break;
                            case "fai1":
                                if (Int32.Parse(stat.FaithBase) >= Int32.Parse(tb3.Text))
                                {
                                    stat.FaithNew = stat.FaithBase;
                                    stat.FaithDiff = "0";
                                }
                                else if (Int32.Parse(tb3.Text) > 99)
                                {
                                    stat.FaithNew = "99";
                                    stat.FaithDiff = (99 - Int32.Parse(stat.FaithBase)).ToString();
                                }
                                else
                                {
                                    stat.FaithNew = tb3.Text;
                                    stat.FaithDiff = (Int32.Parse(stat.FaithNew) - Int32.Parse(stat.FaithBase)).ToString();
                                }
                                break;
                        }

                        int diffSL = Int32.Parse(stat.VigorDiff) + Int32.Parse(stat.EnduranceDiff) + Int32.Parse(stat.VitalityDiff) + Int32.Parse(stat.AttunementDiff)
                             + Int32.Parse(stat.StrengthDiff) + Int32.Parse(stat.DexterityDiff) + Int32.Parse(stat.AdaptabilityDiff) + Int32.Parse(stat.IntelligenceDiff)
                              + Int32.Parse(stat.FaithDiff);

                        if (diffSL >= Int32.Parse(stat.SoulLevelDiff))
                        {
                            stat.SoulLevelDiff = diffSL.ToString();
                            stat.SoulLevelNew = (diffSL + Int32.Parse(stat.SoulLevelBase)).ToString();
                        }
                        else
                        {
                            stat.SoulLevelNew = stat.SoulLevelBase;
                            stat.SoulLevelDiff = "0";
                        }

                        holder.Add(stat);
                    }
                    listat = holder;
                }
            }
        }

        private void UpdateText(TextBox test)
        {
            if (!string.IsNullOrEmpty(test.Text))
            {
                UpdateText();
            }
        }

        private void UpdateText()
        {
            int index = comClass.SelectedIndex - 1;

            sl1.Text = listat[index].SoulLevelBase;
            vig1.Text = listat[index].VigorBase;
            end1.Text = listat[index].EnduranceBase;
            vit1.Text = listat[index].VitalityBase;
            att1.Text = listat[index].AttunementBase;
            str1.Text = listat[index].StrengthBase;
            dex1.Text = listat[index].DexterityBase;
            ada1.Text = listat[index].AdaptabilityBase;
            int1.Text = listat[index].IntelligenceBase;
            fai1.Text = listat[index].FaithBase;

            sl2.Text = listat[index].SoulLevelDiff;
            vig2.Text = listat[index].VigorDiff;
            end2.Text = listat[index].EnduranceDiff;
            vit2.Text = listat[index].VitalityDiff;
            att2.Text = listat[index].AttunementDiff;
            str2.Text = listat[index].StrengthDiff;
            dex2.Text = listat[index].DexterityDiff;
            ada2.Text = listat[index].AdaptabilityDiff;
            int2.Text = listat[index].IntelligenceDiff;
            fai2.Text = listat[index].FaithDiff;

            sl3.Text = listat[index].SoulLevelNew;
            vig3.Text = listat[index].VigorNew;
            end3.Text = listat[index].EnduranceNew;
            vit3.Text = listat[index].VitalityNew;
            att3.Text = listat[index].AttunementNew;
            str3.Text = listat[index].StrengthNew;
            dex3.Text = listat[index].DexterityNew;
            ada3.Text = listat[index].AdaptabilityNew;
            int3.Text = listat[index].IntelligenceNew;
            fai3.Text = listat[index].FaithNew;
        }

        private void check_Click(object sender, EventArgs e)
        {
            int compare = Int32.Parse(listat[comClass.SelectedIndex - 1].SoulLevelNew);
            int selected = comClass.SelectedIndex - 1;
            int lowest = selected;

            List<string> classes = new List<string>();
            classes.Add("Warrior");
            classes.Add("Knight");
            classes.Add("Swordsman");
            classes.Add("Bandit");
            classes.Add("Cleric");
            classes.Add("Sorcerer");
            classes.Add("Explorer");
            classes.Add("Deprived");

            foreach (Stats stat in listat)
            {
                int current = Int32.Parse(stat.SoulLevelNew);
                if (current < compare && Int32.Parse(stat.SoulLevelNew) < Int32.Parse(listat[lowest].SoulLevelNew))
                {
                    lowest = listat.IndexOf(stat);
                }
            }
            if (selected != lowest)
            {
                int diff = Int32.Parse(listat[selected].SoulLevelNew) - Int32.Parse(listat[lowest].SoulLevelNew);
                DialogResult res = MessageBox.Show(classes[lowest] + " has a lower soul level (" + listat[lowest] + ") by " + diff + ".\r\nSelect " + classes[lowest] + " instead?",
                    classes[lowest] + " Suggested!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    comClass.SelectedIndex = lowest + 1;
                }
            }
            else
            {
                MessageBox.Show(classes[selected] + " is already the lowest soul level option.", "Already there!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (string.IsNullOrEmpty(name)) { name = "Unnamed"; }
            DateTime now = DateTime.Now;
            string day = now.Day.ToString();
            string month = now.Month.ToString();
            string year = now.Year.ToString();

            Stats stat = listat[comClass.SelectedIndex - 1];
            
            try
            {
                using (StreamWriter sw = File.CreateText(string.Format(@".\Character Plans\{0} - {1}-{2}-{3}.txt", name, day, month, year)))
                {
                    sw.WriteLine("Build Name: " + name);
                    sw.WriteLine("Class: " + comClass.Text);
                    sw.WriteLine("\r\nSoul Level: " + stat.SoulLevelNew);
                    sw.WriteLine("\r\nFinal Stats");
                    sw.WriteLine("Vigor: " + stat.VigorNew);
                    sw.WriteLine("Endurance: " + stat.EnduranceNew);
                    sw.WriteLine("Vitality: " + stat.VitalityNew);
                    sw.WriteLine("Attunement: " + stat.AttunementNew);
                    sw.WriteLine("Strength: " + stat.StrengthNew);
                    sw.WriteLine("Dexterity: " + stat.DexterityNew);
                    sw.WriteLine("Adaptability: " + stat.AdaptabilityNew);
                    sw.WriteLine("Intelligence: " + stat.IntelligenceNew);
                    sw.WriteLine("Faith: " + stat.FaithNew);
                    sw.WriteLine("\r\nLevelups");
                    sw.WriteLine("Total Soul Levels gained: " + stat.SoulLevelDiff);
                    sw.WriteLine("Vigor: " + stat.VigorDiff);
                    sw.WriteLine("Endurance: " + stat.EnduranceDiff);
                    sw.WriteLine("Vitality: " + stat.VitalityDiff);
                    sw.WriteLine("Attunement: " + stat.AttunementDiff);
                    sw.WriteLine("Strength: " + stat.StrengthDiff);
                    sw.WriteLine("Dexterity: " + stat.DexterityDiff);
                    sw.WriteLine("Adaptability: " + stat.AdaptabilityDiff);
                    sw.WriteLine("Intelligence: " + stat.IntelligenceDiff);
                    sw.WriteLine("Faith: " + stat.FaithDiff);
                    sw.WriteLine(string.Format("\r\n\r\n\r\n{0} build created on {1} at {2}.", name, now.ToString("D"), now.ToString("T")));
                }

                DialogResult res = MessageBox.Show("Save succeeded!  Saved as " + string.Format("{0} - {1}-{2}-{3}.txt", name, day, month, year) 
                    + "\r\nOpen file?", "SUCCESS",
                    MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(string.Format(@".\Character Plans\{0} - {1}-{2}-{3}.txt", name, day, month, year));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed!\r\n\r\nError message: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ClearModel();
        }

        private void ClearModel()
        {
            XDocument xmlDoc = XDocument.Load(@".\data\BaseStats.xml");
            XElement xml = xmlDoc.Root;
            List<XElement> baselist = xml.Elements().ToList();
            List<XElement> holder = new List<XElement>();

            listat.Clear();

            foreach (XElement ele in baselist)
            {
                holder = ele.Elements().ToList();
                Stats stat = new Stats();
                stat.SoulLevelBase = holder[0].Value;
                stat.VigorBase = holder[1].Value;
                stat.EnduranceBase = holder[2].Value;
                stat.VitalityBase = holder[3].Value;
                stat.AttunementBase = holder[4].Value;
                stat.StrengthBase = holder[5].Value;
                stat.DexterityBase = holder[6].Value;
                stat.AdaptabilityBase = holder[7].Value;
                stat.IntelligenceBase = holder[8].Value;
                stat.FaithBase = holder[9].Value;

                stat.SoulLevelNew = holder[0].Value;
                stat.VigorNew = holder[1].Value;
                stat.EnduranceNew = holder[2].Value;
                stat.VitalityNew = holder[3].Value;
                stat.AttunementNew = holder[4].Value;
                stat.StrengthNew = holder[5].Value;
                stat.DexterityNew = holder[6].Value;
                stat.AdaptabilityNew = holder[7].Value;
                stat.IntelligenceNew = holder[8].Value;
                stat.FaithNew = holder[9].Value;

                stat.SoulLevelDiff = "0";
                stat.VigorDiff = "0";
                stat.EnduranceDiff = "0";
                stat.VitalityDiff = "0";
                stat.AttunementDiff = "0";
                stat.StrengthDiff = "0";
                stat.DexterityDiff = "0";
                stat.AdaptabilityDiff = "0";
                stat.IntelligenceDiff = "0";
                stat.FaithDiff = "0";

                listat.Add(stat);
            }

            if (comClass.SelectedIndex > 0)
            {
                int index = comClass.SelectedIndex - 1;

                sl1.Text = listat[index].SoulLevelBase;
                vig1.Text = listat[index].VigorBase;
                end1.Text = listat[index].EnduranceBase;
                vit1.Text = listat[index].VitalityBase;
                att1.Text = listat[index].AttunementBase;
                str1.Text = listat[index].StrengthBase;
                dex1.Text = listat[index].DexterityBase;
                ada1.Text = listat[index].AdaptabilityBase;
                int1.Text = listat[index].IntelligenceBase;
                fai1.Text = listat[index].FaithBase;

                sl2.Text = listat[index].SoulLevelDiff;
                vig2.Text = listat[index].VigorDiff;
                end2.Text = listat[index].EnduranceDiff;
                vit2.Text = listat[index].VitalityDiff;
                att2.Text = listat[index].AttunementDiff;
                str2.Text = listat[index].StrengthDiff;
                dex2.Text = listat[index].DexterityDiff;
                ada2.Text = listat[index].AdaptabilityDiff;
                int2.Text = listat[index].IntelligenceDiff;
                fai2.Text = listat[index].FaithDiff;

                sl3.Text = listat[index].SoulLevelNew;
                vig3.Text = listat[index].VigorNew;
                end3.Text = listat[index].EnduranceNew;
                vit3.Text = listat[index].VitalityNew;
                att3.Text = listat[index].AttunementNew;
                str3.Text = listat[index].StrengthNew;
                dex3.Text = listat[index].DexterityNew;
                ada3.Text = listat[index].AdaptabilityNew;
                int3.Text = listat[index].IntelligenceNew;
                fai3.Text = listat[index].FaithNew;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateModel(vig1, vig2, vig3);
            UpdateModel(end1, end2, end3);
            UpdateModel(vit1, vit2, vit3);
            UpdateModel(att1, att2, att3);
            UpdateModel(str1, str2, str3);
            UpdateModel(dex1, dex2, dex3);
            UpdateModel(ada1, ada2, ada3);
            UpdateModel(int1, int2, int3);
            UpdateModel(fai1, fai2, fai3);
            UpdateText(fai3);
        }
    }
}