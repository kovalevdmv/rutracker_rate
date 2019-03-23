using CsQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rutracker_rate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Link : IComparable<Link>
        {
            public Link(int seeds, string link, string text)
            {
                this.seeds = seeds;
                this.link = "https://rutracker.org/forum/"+link;
                this.text = text;
            }
            public int seeds;
            public string link;
            public string text;

            public int CompareTo(Link link)
            {
                return this.seeds.CompareTo(link.seeds);
            }
        }

        async void get_textAsync()
        {

           List<Link> list = new List<Link>();

            int index = 0;

            bool err=false;

            while (index <= Convert.ToInt32(textBoxEndPage.Text)*50)
            {
                toolStripStatusLabel1.Text = "Обработка страницы " + (index/50).ToString()+" ("+ textBoxStartPage.Text + "&start=" + index.ToString()+")";
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(textBoxStartPage.Text+"&start="+index.ToString());
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        CQ dom = CQ.Create(responseBody);

                        var tr = dom.Find("tr.hl-tr");

                        foreach(var el in tr)
                        {
                            if ((el.Cq().Find("span.seedmed").Length == 0) || (el.Cq().Find("a.torTopic").Length == 0))
                                continue;
                            var link_text = el.Cq().Find("a.torTopic")[0].FirstChild.NodeValue;
                            var link_ref = el.Cq().Find("a.torTopic")[0].GetAttribute("href");
                            var seeds = Convert.ToInt32(el.Cq().Find("span.seedmed")[0].FirstChild.InnerText);
                            var l = new Link(seeds, link_ref, link_text);
                            list.Add(l);
                        }

                    }
                    catch (HttpRequestException e)
                    {
                        if (index == 0) {
                            err = true;
                            MessageBox.Show("Ошибка загрузки страницы, возможно не запущен VPN н.п. https://rus.windscribe.com/");
                        }
                        break;    
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Некорректно указан URL");
                        err = true;
                        break;
                    }
                }

                index += 50;
            }

            if (err)
                return;

            if (list.Count == 0)
            {
                MessageBox.Show("На указанной странице не найдена информация о ссылках и их загрузках (сидах)");
                return;
            }

            list.Sort();
            list.Reverse();

            DataTable dt = new DataTable();
            dt.Columns.Add("seeds");
            dt.Columns.Add("text");
            dt.Columns.Add("link");

            foreach (Link el in list)
            {
                DataRow r = dt.NewRow();
                r["seeds"] = el.seeds;
                r["text"] = el.text;
                r["link"] = el.link;
                dt.Rows.Add(r);
            }

            dataGridView1.DataSource = dt;

            toolStripStatusLabel1.Text = "Готово";
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            get_textAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            checkBoxOpacity.Checked = true;

            DataTable dt = new DataTable();
            dt.Columns.Add("seeds");
            dt.Columns.Add("text");
            dt.Columns.Add("link");
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["link"].Visible = false;
            dataGridView1.Columns["seeds"].Width = 50;
            dataGridView1.Columns["text"].Width = 400;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = dataGridView1[2,e.RowIndex].Value.ToString();
            p.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxStartPage.Text = Clipboard.GetText();
            get_textAsync();
        }

        private void зарубежные2019ГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "зарубежные2019Год";
            textBoxStartPage.Text = "https://rutracker.org/forum/viewforum.php?f=1950";
            get_textAsync();
        }

        private void зарубежные20162018ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "зарубежные20162018";
            textBoxStartPage.Text = "https://rutracker.org/forum/viewforum.php?f=2200";
            get_textAsync();
        }

        private void нашеКиноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "нашеКино";
            textBoxStartPage.Text = "https://rutracker.org/forum/viewforum.php?f=22";
            get_textAsync();
        }

        private void сериалыЗпрубежныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "сериалыЗпрубежные";
            textBoxStartPage.Text = "https://rutracker.org/forum/viewforum.php?f=189";
            get_textAsync();
        }

        private void сериалыНашиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "сериалыНаши";
            textBoxStartPage.Text = "https://rutracker.org/forum/viewforum.php?f=9";
            get_textAsync();
        }

        private void checkBoxOpacity_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxOpacity_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
               Opacity = 1;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxOpacity.Checked)
                    Opacity = 0.7;
            } catch (Exception ex)
            {

            }
        }
    }
}
