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
        public List<Model.AGENTS> oAgentes;
        public List<Model.CUSTOMER> oCustomers;
        public List<Model.ORDERS> oOrders;
        public int indice = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {



            using (Model.DB2EntityContainer db = new Model.DB2EntityContainer())
            {
                var oAgents = db.AGENTS.ToList();
                if (oAgents.Count > 0)
                {
                    MessageBox.Show("La base de datos ya contiene informacion ", "operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //TODO
                    using (var dbTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            List<Model.AGENTS> agentes = new List<Model.AGENTS>();

                            agentes.Add(new Model.AGENTS { AGENT_CODE = 7, AGENT_NAME = "Ramasundar", WORKING_AREA = "Bangalore", COMISSION = 0.15m, COUNTRY = "", PHONE_NO = "077-25814763" });
                            agentes.Add(new Model.AGENTS { AGENT_CODE = 3, AGENT_NAME = "Alex", WORKING_AREA = "London", COMISSION = 0.15m, COUNTRY = "", PHONE_NO = "075-12458969" });
                            agentes.Add(new Model.AGENTS { AGENT_CODE = 8, AGENT_NAME = "Alford", WORKING_AREA = "New york", COMISSION = 0.15m, COUNTRY = "", PHONE_NO = "044-25874365" });
                            agentes.Add(new Model.AGENTS { AGENT_CODE = 10, AGENT_NAME = "Santakumar", WORKING_AREA = "Channel", COMISSION = 0.15m, COUNTRY = "", PHONE_NO = "007-22388644" });
                            agentes.Add(new Model.AGENTS { AGENT_CODE = 12, AGENT_NAME = "Lucida", WORKING_AREA = "San jose", COMISSION = 0.15m, COUNTRY = "", PHONE_NO = "044-52981425" });
                            agentes.Add(new Model.AGENTS { AGENT_CODE = 5, AGENT_NAME = "Anderson", WORKING_AREA = "Brisban", COMISSION = 0.15m, COUNTRY = "", PHONE_NO = "045-21447739" });
                            agentes.Add(new Model.AGENTS { AGENT_CODE = 4, AGENT_NAME = "Ivan", WORKING_AREA = "Torento", COMISSION = 0.15m, COUNTRY = "", PHONE_NO = "008-22544166" });

                            db.AGENTS.AddRange(agentes);


                            List<Model.CUSTOMER> clientes = new List<Model.CUSTOMER>();

                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 13, CUST_NAME = "Holmes", CUST_CITY = "London", WORKING_AREA = "London", CUST_COUNTRY = "UK", GRADE = 2, OPENING_AMT = 6000.00m, RECEIVE_AMT = 5000.00m, PAYMENT_AMT = 7000.00m, OUTSTANDING_AMT = 4000.00m, PHONE_NO = "BBBBBBB", AGENT_CODE = 3 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 1, CUST_NAME = "Michael", CUST_CITY = "New York", WORKING_AREA = "New York", CUST_COUNTRY = "USA", GRADE = 2, OPENING_AMT = 3000.00m, RECEIVE_AMT = 5000.00m, PAYMENT_AMT = 2000.00m, OUTSTANDING_AMT = 6000.00m, PHONE_NO = "CCCCCCC", AGENT_CODE = 8 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 20, CUST_NAME = "Albert", CUST_CITY = "New York", WORKING_AREA = "New York", CUST_COUNTRY = "USA", GRADE = 3, OPENING_AMT = 5000.00m, RECEIVE_AMT = 7000.00m, PAYMENT_AMT = 6000.00m, OUTSTANDING_AMT = 6000.00m, PHONE_NO = "BBBBSBB", AGENT_CODE = 8 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 15, CUST_NAME = "Stuart", CUST_CITY = "London", WORKING_AREA = "London", CUST_COUNTRY = "UK", GRADE = 1, OPENING_AMT = 6000.00m, RECEIVE_AMT = 8000.00m, PAYMENT_AMT = 3000.00m, OUTSTANDING_AMT = 11000.00m, PHONE_NO = "GFSGERS", AGENT_CODE = 3 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 2, CUST_NAME = "Bolt", CUST_CITY = "New York", WORKING_AREA = "New York", CUST_COUNTRY = "USA", GRADE = 3, OPENING_AMT = 5000.00m, RECEIVE_AMT = 7000.00m, PAYMENT_AMT = 9000.00m, OUTSTANDING_AMT = 3000.00m, PHONE_NO = "DDNRDRH", AGENT_CODE = 8 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 15, CUST_NAME = "Fleming", CUST_CITY = "Brisban", WORKING_AREA = "Brisban", CUST_COUNTRY = "Australia", GRADE = 2, OPENING_AMT = 7000.00m, RECEIVE_AMT = 7000.00m, PAYMENT_AMT = 9000.00m, OUTSTANDING_AMT = 5000.00m, PHONE_NO = "NHBGVFC", AGENT_CODE = 5 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 15, CUST_NAME = "Jacks", CUST_CITY = "Brisban", WORKING_AREA = "Brisban", CUST_COUNTRY = "Austraulia", GRADE = 1, OPENING_AMT = 7000.00m, RECEIVE_AMT = 7000.00m, PAYMENT_AMT = 7000.00m, OUTSTANDING_AMT = 7000.00m, PHONE_NO = "WERTGDF", AGENT_CODE = 10 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 15, CUST_NAME = "Yearannaidu", CUST_CITY = "Chennai", WORKING_AREA = "Chennai", CUST_COUNTRY = "India", GRADE = 1, OPENING_AMT = 8000.00m, RECEIVE_AMT = 7000.00m, PAYMENT_AMT = 8000.00m, OUTSTANDING_AMT = 8000.00m, PHONE_NO = "ZZZZBFV", AGENT_CODE = 10 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 15, CUST_NAME = "Ramanathan", CUST_CITY = "Chennai", WORKING_AREA = "Chennai", CUST_COUNTRY = "India", GRADE = 1, OPENING_AMT = 7000.00m, RECEIVE_AMT = 11000.00m, PAYMENT_AMT = 9000.00m, OUTSTANDING_AMT = 9000.00m, PHONE_NO = "GHRDWSD", AGENT_CODE = 5 });
                            clientes.Add(new Model.CUSTOMER { CUST_CODE = 15, CUST_NAME = "Winston", CUST_CITY = "Brisban", WORKING_AREA = "Brisban", CUST_COUNTRY = "Austraulia", GRADE = 1, OPENING_AMT = 5000.00m, RECEIVE_AMT = 8000.00m, PAYMENT_AMT = 7000.00m, OUTSTANDING_AMT = 6000.00m, PHONE_NO = "AAAAAAA", AGENT_CODE = 5 });

                            db.CUSTOMER.AddRange(clientes);

                            List<Model.ORDERS> ordenes = new List<Model.ORDERS>();

                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200100, ORD_AMOUNT = 1000.00m, ADVENCE_AMOUNT = 600.00m, ORD_DATE = new DateTime(2008, 08, 01), ORD_DESCRIPTION = "SOD", AGENT_CODE = 3, CUST_CODE = 13 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200110, ORD_AMOUNT = 3000.00m, ADVENCE_AMOUNT = 500.00m, ORD_DATE = new DateTime(2008, 04, 15), ORD_DESCRIPTION = "SOD", AGENT_CODE = 10, CUST_CODE = 19 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200107, ORD_AMOUNT = 4500.00m, ADVENCE_AMOUNT = 900.00m, ORD_DATE = new DateTime(2008, 08, 30), ORD_DESCRIPTION = "SOD", AGENT_CODE = 10, CUST_CODE = 7 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200114, ORD_AMOUNT = 3500.00m, ADVENCE_AMOUNT = 2000.00m, ORD_DATE = new DateTime(2008, 08, 15), ORD_DESCRIPTION = "SOD", AGENT_CODE = 8, CUST_CODE = 2 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200119, ORD_AMOUNT = 4000.00m, ADVENCE_AMOUNT = 700.00m, ORD_DATE = new DateTime(2008, 09, 16), ORD_DESCRIPTION = "SOD", AGENT_CODE = 10, CUST_CODE = 7 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200134, ORD_AMOUNT = 4200.00m, ADVENCE_AMOUNT = 1800.00m, ORD_DATE = new DateTime(2008, 09, 25), ORD_DESCRIPTION = "SOD", AGENT_CODE = 5, CUST_CODE = 4 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200103, ORD_AMOUNT = 1500.00m, ADVENCE_AMOUNT = 700.00m, ORD_DATE = new DateTime(2008, 05, 15), ORD_DESCRIPTION = "SOD", AGENT_CODE = 5, CUST_CODE = 21 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200101, ORD_AMOUNT = 3000.00m, ADVENCE_AMOUNT = 1000.00m, ORD_DATE = new DateTime(2008, 07, 15), ORD_DESCRIPTION = "SOD", AGENT_CODE = 8, CUST_CODE = 1 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200111, ORD_AMOUNT = 1000.00m, ADVENCE_AMOUNT = 300.00m, ORD_DATE = new DateTime(2008, 07, 10), ORD_DESCRIPTION = "SOD", AGENT_CODE = 8, CUST_CODE = 20 });
                            ordenes.Add(new Model.ORDERS { ORD_NUM = 200125, ORD_AMOUNT = 2000.00m, ADVENCE_AMOUNT = 600.00m, ORD_DATE = new DateTime(2008, 10, 10), ORD_DESCRIPTION = "SOD", AGENT_CODE = 5, CUST_CODE = 18 });

                            db.ORDERS.AddRange(ordenes);

                            db.SaveChanges();
                            dbTransaction.Commit();

                            MessageBox.Show(" La base de datos fue poblada con exito ", " Operacion exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            dbTransaction.Rollback();
                            MessageBox.Show("An unexpected error occured, database could not be filled. \n\nApplication will be closed.", "Error found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();

                            return;
                        }
                    }

                }
                button1.Enabled = false;

                oAgentes = db.AGENTS.ToList();
                oCustomers = db.CUSTOMER.ToList();
                oOrders = db.ORDERS.ToList();
                indice = 0;
                Llenar();
            }

        }
        public void Llenar()
        {

            if (indice < 0)
                indice = 0;

            if (indice >= oAgentes.Count)
                indice = oAgentes.Count - 1;

            string cadena = "";
            string cadena2 = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            cadena = oAgentes[indice].AGENT_CODE.ToString() + " - " + oAgentes[indice].AGENT_NAME + ", en " + oAgentes[indice].WORKING_AREA;
            textBox1.Text = cadena;

            List<Model.CUSTOMER> iCustomer = new List<Model.CUSTOMER>();
            iCustomer = oCustomers.Where(a => a.AGENT_CODE == (int)oAgentes[indice].AGENT_CODE).ToList();

            if (iCustomer != null)
            {

                cadena = "";
                cadena2 = "";


                for (int i = 0; i < iCustomer.Count; i++)
                {

                    cadena = cadena + iCustomer[i].CUST_CODE.ToString() + " - " + iCustomer[i].CUST_NAME + ",";

                    List<Model.ORDERS> jOrder = new List<Model.ORDERS>();
                    jOrder = oOrders.Where(a => a.AGENT_CODE == (int)oAgentes[indice].AGENT_CODE && a.CUST_CODE == (int)iCustomer[i].CUST_CODE).ToList();
                    if (jOrder != null)
                    {

                        for (int j = 0; j < jOrder.Count; j++)
                        {

                            cadena2 = cadena2 + jOrder[j].ORD_NUM.ToString() + ",";



                        }

                    }
                }
                textBox2.Text = cadena;
                textBox3.Text = cadena2;




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            indice--;
            Llenar();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            indice++;
            Llenar();

        }
    }


}
