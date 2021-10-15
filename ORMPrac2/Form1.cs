using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMPrac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Model.DB2EntityContainer db = new Model.DB2EntityContainer())
            {

                    using (var dbTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            List<Model.AGENTS> agents = new List<Model.AGENTS>();

                            agents.Add(new Model.AGENTS { AGENT_CODE = 6, AGENT_NAME = "Ramasundar", WORKING_AREA = "Bangalore", COMMISSION = 0.15m, COUNTRY = "", PHONE_NO = "077-25814763" });
                            agents.Add(new Model.AGENTS { AGENT_CODE = 3, AGENT_NAME = "Alex", WORKING_AREA = "London", COMMISSION = 0.13m, COUNTRY = "", PHONE_NO = "075-12458969" });

                            db.AGENTS.AddRange(agents);
                            db.SaveChanges();
                            dbTransaction.Commit();

                            MessageBox.Show("Database has been populated successfully", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            dbTransaction.Rollback();
                            MessageBox.Show("An unexpected error occured, database could not be filled. \n\nApplication will be closed.", "Error found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();

                            return;
                        }
                    }

                    MessageBox.Show("Database has been populated successfully", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                button1.Enabled = false;
            }
        }
    }
}
