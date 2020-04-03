using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Kitchen
{
   
    public partial class Form1 : Form
    {
        String name, size, qty;
        IFirebaseClient client;
        EventStreamResponse respons;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lJ00CGCubk8WK0tl0zD2ZUULDmVkUfVA1fXqqs0V",
            BasePath = "https://c-sharp-2a4aa.firebaseio.com/"
        };
        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            read();

        }

        public async void read()
        {
            respons = await client.OnAsync("pending", (sender, args, context) => {

                //Console.WriteLine(args.Path);
                //Console.WriteLine(args.Data);
                //addToKitchen(args.Path);
                //addItem();
                Console.WriteLine("changed");
                getNewOrderDetails(args.Path.ToString());
                
                

            });
          
        }


        
        public void addToKitchen(String path)
        {
            Console.WriteLine(path + "added to pening list ");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            read();
        }

        public void x(String x)
        {
            if (x.Length > 1)
            {
                //addItem("1", "1", "1");
            }
           
        }
        int poss = 40;
        public  void addItem()
        {
            
            if (button1.InvokeRequired)
            {
                button1.Invoke(new Action(addItem));

                return;
            }


            OrdersNew item = new Kitchen.OrdersNew(name,size,qty);
            panel3.Controls.Add(item);
            item.Top = poss;
            item.Left = 20;
            poss = (item.Top + item.Height + 10);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public async void getNewOrderDetails(String path)
        {
            Console.WriteLine("firebase called");
            FirebaseResponse response = await client.GetAsync("Orders/007/" + path);
            ItemDetails obj = response.ResultAs<ItemDetails>();
            Console.WriteLine(obj.itemCode);
            Console.WriteLine(obj.qty);
            Console.WriteLine(obj.size);
            Console.WriteLine(obj.status);
            Console.WriteLine(obj.tblNo);
            String name = obj.itemCode.ToString();
            String size = obj.size.ToString();
            String qty = obj.qty.ToString();
            //respons.Dispose();
            this.name = name;
            this.size = size;
            this.qty = qty;
            addItem();
            deleteFromPending(path);
            //read();

        }
        public async void deleteFromPending(String path)
        {
            FirebaseResponse response = await client.DeleteAsync("pending/" + path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem();

        }


       
    }
}
