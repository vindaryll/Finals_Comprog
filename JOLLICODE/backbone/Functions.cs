using MySql.Data.MySqlClient;
using System.Data;
using pv = backbone.PublicVariables;
namespace backbone
{
    public class Functions
    {

        DbConnect dbcon = new();


        public void VarReset()
        {
            // reseting strings, arrays, and numeric values to default
            pv.customerName = string.Empty;
            pv.customerAddress = string.Empty;
            pv.customerContact = string.Empty;

            for (int i = 0; i < pv.itemID.Length; i++)
            {
                pv.itemID[i] = 0;
            }
            for (int i = 0; i < pv.itemName.Length; i++)
            {
                pv.itemName[i] = string.Empty;
            }
            for (int i = 0; i < pv.itemPrice.Length; i++)
            {
                pv.itemPrice[i] = 0;
            }
            for (int i = 0; i < pv.itemDescription.Length; i++)
            {
                pv.itemDescription[i] = string.Empty;
            }
            for (int i = 0; i < pv.itemAvailability.Length; i++)
            {
                pv.itemAvailability[i] = false;
            }
            for (int i = 0; i < pv.itemQuantity.Length; i++)
            {
                pv.itemQuantity[i] = 0;
            }
            for (int i = 0; i < pv.mealTotal.Length; i++)
            {
                pv.mealTotal[i] = 0;
            }

            pv.indexItem = 0;
            pv.paymentMethod = string.Empty;
            pv.paymentAmount = 0;
            pv.changeAmount = 0;
            pv.totalQuantity = 0;
            pv.totalBill = 0;
            pv.customerID = 0;
            pv.isNewCustomer = false;
            pv.orderID = 0;
            pv.date = string.Empty;

            pv.username = string.Empty;
            pv.password = string.Empty;
            pv.verification = string.Empty;

            pv.adminItemIndex = 0;
            pv.currentPrice = 0;
            for (int i = 0; i < pv.record_itemID.Length; i++)
            {
                pv.record_itemID[i] = 0;
            }
            for (int i = 0; i < pv.record_itemName.Length; i++)
            {
                pv.record_itemName[i] = string.Empty;
            }
            for (int i = 0; i < pv.record_itemName.Length; i++)
            {
                pv.record_itemName[i] = string.Empty;
            }
            for (int i = 0; i < pv.record_quantity.Length; i++)
            {
                pv.record_quantity[i] = 0;
            }
            for (int i = 0; i < pv.record_mealtotal.Length; i++)
            {
                pv.record_mealtotal[i] = 0; ;
            }
        }

        // REFRESHING DATA ON DB
        public void refreshCustomer()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE Customer AS c JOIN (SELECT CustomerID, ROW_NUMBER() OVER (ORDER BY CustomerID) AS new_customer_id FROM Customer) AS rc ON c.CustomerID = rc.CustomerID SET c.CustomerID = rc.new_customer_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void refreshOrders()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE Orders AS o JOIN (SELECT OrderID, ROW_NUMBER() OVER (ORDER BY OrderID) AS new_order_id FROM Orders) AS ro ON o.OrderID = ro.OrderID SET o.OrderID = ro.new_order_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void refreshOrderTransaction()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE OrderTransaction AS ot JOIN (SELECT TransactionID, ROW_NUMBER() OVER (ORDER BY TransactionID) AS new_transaction_id FROM OrderTransaction) AS rot ON ot.TransactionID = rot.TransactionID SET ot.TransactionID = rot.new_transaction_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void refreshOrderItem()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE OrderItem AS oi JOIN (SELECT OrderItemID, ROW_NUMBER() OVER (ORDER BY OrderItemID) AS new_orderitem_id FROM OrderItem) AS roi ON oi.OrderItemID = roi.OrderItemID SET oi.OrderItemID = roi.new_orderitem_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        // FOR INSERTING DATA ON DB
        public void InsertCustomers(string customername, string customercontact, string customeraddress)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO Customer (CustomerName, ContactNumber, Address) VALUES ('{customername}', '{customercontact}', '{customeraddress}');";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void InsertOrders(int customerid, string paymentmethod)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO Orders (CustomerID, OrderTime, PaymentMethod) VALUES ({customerid}, CURRENT_TIMESTAMP, '{paymentmethod}');";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void InsertOrderTransaction(int orderid, double total, double paymentamount, double changeamount)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO OrderTransaction (OrderID, Total, AmountPaid, ChangeAmount) VALUES ({orderid}, {total}, {paymentamount}, {changeamount});";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void InsertOrderItem(int orderid, int itemid, double itemquantity, double mealtotal)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO OrderItem (OrderID, ItemID, Quantity, MealTotal) VALUES ({orderid}, {itemid}, {itemquantity}, {mealtotal})";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void getCustomerID(string name, string contact)
        {
            try
            {
                dbcon.OpenCon();
                string query = "SELECT CustomerID FROM customer WHERE CustomerName = '" + name + "' AND ContactNumber = '" + contact + "' LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    pv.customerID = reader.GetInt32(reader.GetOrdinal("CustomerID"));
                }
                else
                {
                    dbcon.CloseCon();

                    dbcon.OpenCon();
                    string query2 = "SELECT CustomerID FROM customer ORDER BY CustomerID DESC LIMIT 1;";
                    cmd = new MySqlCommand(query2, dbcon.Getcon());
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        pv.customerID = reader.GetInt32(reader.GetOrdinal("CustomerID")) + 1;
                        pv.isNewCustomer = true;
                    }
                    else
                    {
                        pv.customerID = 1;
                        pv.isNewCustomer = true;
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void getOrderID()
        {
            try
            {
                dbcon.OpenCon();
                string query = "SELECT OrderID FROM orders ORDER BY OrderID DESC LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    pv.orderID = reader.GetInt32(reader.GetOrdinal("OrderID")) + 1;
                    reader.Close();
                }
                else
                {
                    pv.orderID = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }


        }

        public void getDate()
        {
            try
            {
                dbcon.OpenCon();
                string query = $"SELECT OrderTime FROM ORDERS WHERE OrderID = {pv.orderID};";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    pv.date = reader.GetString(reader.GetOrdinal("OrderTime"));
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Insert the data on the db first");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        // FOR ORDER PROCESS
        public void getItemInfo()
        {
            int i = 0;
            int rowCount = 0;
            try
            {
                dbcon.OpenCon();

                string query = "SELECT ItemID, ItemName, Price, Description, Availability FROM Item ORDER BY ItemID;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        rowCount++; // to get the size of array
                    }

                    pv.itemID = new int[rowCount];
                    pv.itemName = new string[rowCount];
                    pv.itemPrice = new double[rowCount];
                    pv.itemDescription = new string[rowCount];
                    pv.itemAvailability = new bool[rowCount];

                    pv.itemQuantity = new double[rowCount];
                    pv.mealTotal = new double[rowCount];


                    reader.Close();

                    // start new reading
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        pv.itemID[i] = reader.GetInt32(reader.GetOrdinal("ItemID"));
                        pv.itemName[i] = reader.GetString(reader.GetOrdinal("ItemName"));
                        pv.itemPrice[i] = reader.GetDouble(reader.GetOrdinal("Price"));
                        pv.itemDescription[i] = reader.GetString(reader.GetOrdinal("Description"));
                        pv.itemAvailability[i] = reader.GetBoolean(reader.GetOrdinal("Availability"));

                        i++;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }



        // FOR PICTURES
        public void picture(int index, PictureBox pictureBox1)
        {
            string[] maindish = new string[10];
            string[] Umaindish = new string[10];
            string[] sidedish = new string[5];
            string[] Usidedish = new string[5];
            string[] beverage = new string[7];
            string[] Ubeverage = new string[7];

            // for maindish
            for (int i = 0; i < 10; i++)
            {
                
                maindish[i] = $"{pv.folderPath}picture\\order\\maindish{i + 1:D2}.png";
                Umaindish[i] = $"{pv.folderPath}picture\\order\\Umaindish{i + 1:D2}.png";
            }
            // for sidedish
            for (int i = 0; i < 5; i++)
            {
                sidedish[i] = $"{pv.folderPath}picture\\order\\sidedish{i + 1:D2}.png";
                Usidedish[i] = $"{pv.folderPath}picture\\order\\Usidedish{i + 1:D2}.png";
            }
            // for beverages
            for (int i = 0; i < 7; i++)
            {
                beverage[i] = $"{pv.folderPath}picture\\order\\beverage{i + 1:D2}.png";
                Ubeverage[i] = $"{pv.folderPath}picture\\order\\Ubeverage{i + 1:D2}.png";
            }

            if (index <= 9 && index >= 0)
            {
                if (pv.itemAvailability[index])
                {
                    if (System.IO.File.Exists(maindish[index]))
                    {
                        pictureBox1.Image = Image.FromFile(maindish[index]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
                else
                {
                    if (System.IO.File.Exists(Umaindish[index]))
                    {
                        pictureBox1.Image = Image.FromFile(Umaindish[index]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
            }
            else if (index <= 14 && index >= 10)
            {
                if (pv.itemAvailability[index])
                {
                    if (System.IO.File.Exists(sidedish[index - 10]))
                    {
                        pictureBox1.Image = Image.FromFile(sidedish[index - 10]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
                else
                {
                    if (System.IO.File.Exists(Usidedish[index - 10]))
                    {
                        pictureBox1.Image = Image.FromFile(Usidedish[index - 10]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
            }
            else if (index <= 21 && index >= 15)
            {
                if (pv.itemAvailability[index])
                {
                    if (System.IO.File.Exists(beverage[index - 15]))
                    {
                        pictureBox1.Image = Image.FromFile(beverage[index - 15]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
                else
                {
                    if (System.IO.File.Exists(Ubeverage[index - 15]))
                    {
                        pictureBox1.Image = Image.FromFile(Ubeverage[index - 15]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
            }
        }

        public void picsUpdate(int index, Button btn1, Button btn2)
        {
            string[] maindish = new string[10];
            string[] Umaindish = new string[10];
            string[] sidedish = new string[5];
            string[] Usidedish = new string[5];
            string[] beverage = new string[7];
            string[] Ubeverage = new string[7];

            // for maindish
            for (int i = 0; i < 10; i++)
            {
                maindish[i] = $"{pv.folderPath}picture\\update\\maindish{i + 1:D2}.png";
                Umaindish[i] = $"{pv.folderPath}picture\\update\\Umaindish{i + 1:D2}.png";
            }
            // for sidedish
            for (int i = 0; i < 5; i++)
            {
                sidedish[i] = $"{pv.folderPath}picture\\update\\sidedish{i + 1:D2}.png";
                Usidedish[i] = $"{pv.folderPath}picture\\update\\Usidedish{i + 1:D2}.png";
            }
            // for beverages
            for (int i = 0; i < 7; i++)
            {
                beverage[i] = $"{pv.folderPath}picture\\update\\beverage{i + 1:D2}.png";
                Ubeverage[i] = $"{pv.folderPath}picture\\update\\Ubeverage{i + 1:D2}.png";
            }

            if (index <= 9 && index >= 0)
            {
                if (System.IO.File.Exists(maindish[index]))
                {
                    btn1.BackgroundImage = Image.FromFile(maindish[index]);
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }

                if (System.IO.File.Exists(Umaindish[index]))
                {
                    btn2.BackgroundImage = Image.FromFile(Umaindish[index]);
                    btn2.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
            }
            else if (index <= 14 && index >= 10)
            {
                if (System.IO.File.Exists(sidedish[index - 10]))
                {
                    btn1.BackgroundImage = Image.FromFile(sidedish[index - 10]);
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
                if (System.IO.File.Exists(Usidedish[index - 10]))
                {
                    btn2.BackgroundImage = Image.FromFile(Usidedish[index - 10]);
                    btn2.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
            }
            else if (index <= 21 && index >= 15)
            {
                if (System.IO.File.Exists(beverage[index - 15]))
                {
                    btn1.BackgroundImage = Image.FromFile(beverage[index - 15]);
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
                if (System.IO.File.Exists(Ubeverage[index - 15]))
                {
                    btn2.BackgroundImage = Image.FromFile(Ubeverage[index - 15]);
                    btn2.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
            }
        }

        // ORDER PICTURES
        // for pic boxes
        public void mainDish(PictureBox[] pictureBoxes)
        {
            string[] imagePaths = new string[10];
            for (int i = 0; i < 10; i++)
            {
                if (pv.itemAvailability[i])
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\maindish{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\Umaindish{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(imagePaths[i]);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void sideDish(PictureBox[] pictureBoxes)
        {
            string[] imagePaths = new string[5];
            for (int i = 0; i < 5; i++)
            {
                if (pv.itemAvailability[i + 10])
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\sidedish{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\Usidedish{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(imagePaths[i]);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void beverages(PictureBox[] pictureBoxes)
        {
            string[] imagePaths = new string[7];
            for (int i = 0; i < 7; i++)
            {
                if (pv.itemAvailability[i + 15])
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\beverage{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\Ubeverage{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(imagePaths[i]);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // for btns
        public void mainDishBtns(Button[] buttons)
        {
            string[] imagePaths = new string[10];
            for (int i = 0; i < 10; i++)
            {
                if (pv.itemAvailability[i])
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\maindish{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\Umaindish{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                buttons[i].BackgroundImage = Image.FromFile(imagePaths[i]);
                buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void sideDishBtns(Button[] buttons)
        {
            string[] imagePaths = new string[5];
            for (int i = 0; i < 5; i++)
            {
                if (pv.itemAvailability[i + 10])
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\sidedish{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\Usidedish{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                buttons[i].BackgroundImage = Image.FromFile(imagePaths[i]);
                buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void beveragesBtns(Button[] buttons)
        {
            string[] imagePaths = new string[7];
            for (int i = 0; i < 7; i++)
            {
                if (pv.itemAvailability[i + 15])
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\beverage{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"{pv.folderPath}picture\\order\\Ubeverage{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                buttons[i].BackgroundImage = Image.FromFile(imagePaths[i]);
                buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        // UPDATE

        public void updateAvailability(int index, bool var)
        {
            try
            {
                string query = $"UPDATE Item SET Availability = {var} WHERE ItemID = {index + 1};";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }



        public void showItemOnDT(DataGridView dtv)
        {
            dtv.Rows.Clear();
            for (int i = 0; i < pv.itemID.Length; i++)
            {
                if (pv.itemQuantity[i] > 0)
                {
                    dtv.Rows.Add(
                        pv.itemID[i],
                        pv.itemName[i],
                        pv.itemQuantity[i],
                        pv.mealTotal[i].ToString("N2")
                                );
                }

            }

        }



        // ADMIN
        public void getAdminInfo()
        {
            try
            {
                dbcon.OpenCon();
                string query = "SELECT Username, Password, Verification FROM Admin;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                pv.username = reader.GetString(reader.GetOrdinal("Username"));
                pv.password = reader.GetString(reader.GetOrdinal("Password"));
                pv.verification = reader.GetString(reader.GetOrdinal("Verification"));
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }
        public void updatePass(string new_pass)
        {
            try
            {
                string query = $"UPDATE Admin SET Password = '{new_pass}' WHERE Username = 'Admin'";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void getCurrentPrice(int index)
        {
            try
            {
                string query = $"SELECT Price FROM item WHERE ItemID = '{index + 1}';";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                pv.currentPrice = reader.GetInt32(reader.GetOrdinal("Price"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }
        public void updatePrice(double price, int index)
        {
            try
            {
                string query = $"UPDATE Item SET Price = '{price}' WHERE ItemID = '{index + 1}';";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }
        public void Displaydata(DataGridView dgv, string query)
        {

            dbcon.OpenCon();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, dbcon.Getcon());
            adapt.Fill(dt);
            dgv.DataSource = dt;
            dbcon.CloseCon();
        }
        public void getRecordsInfo()
        {
            // Customer info

            try
            {
                dbcon.OpenCon();
                string query = $"SELECT C.CustomerID, C.CustomerName, C.Address, C.ContactNumber, OT.Total AS TotalBill, OT.AmountPaid AS Payment, OT.ChangeAmount AS `Change` FROM Orders O JOIN Customer C ON O.CustomerID = C.CustomerID JOIN OrderTransaction OT ON O.OrderID = OT.OrderID WHERE O.OrderID = {pv.orderID};";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    pv.customerID = reader.GetInt32(reader.GetOrdinal("CustomerID"));
                    pv.customerName = reader.GetString(reader.GetOrdinal("CustomerName"));
                    pv.customerAddress = reader.GetString(reader.GetOrdinal("Address"));
                    pv.customerContact = reader.GetString(reader.GetOrdinal("ContactNumber"));
                    pv.totalBill = reader.GetDouble(reader.GetOrdinal("TotalBill"));
                    pv.paymentAmount = reader.GetDouble(reader.GetOrdinal("Payment"));
                    pv.changeAmount = reader.GetDouble(reader.GetOrdinal("Change"));
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Insert the data on the db first");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }

            // Item info

            int i = 0;
            int rowCount = 0;

            try
            {
                dbcon.OpenCon();

                string query = $"SELECT i.ItemID, i.ItemName, oi.Quantity, oi.MealTotal FROM Item AS i JOIN OrderItem AS oi ON oi.ItemID = i.ItemID JOIN Orders AS o ON o.OrderID = oi.OrderID WHERE o.OrderID = {pv.orderID} GROUP BY i.ItemName, oi.Quantity, oi.MealTotal ORDER BY i.ItemID";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        rowCount++; // to get the size of array
                    }
                    pv.record_itemID = new int[rowCount];
                    pv.record_itemName = new string[rowCount];
                    pv.record_quantity = new double[rowCount];
                    pv.record_mealtotal = new double[rowCount];


                    reader.Close();

                    // start new reading
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        pv.record_itemID[i] = reader.GetInt32(reader.GetOrdinal("ItemID"));
                        pv.record_itemName[i] = reader.GetString(reader.GetOrdinal("ItemName"));
                        pv.record_quantity[i] = reader.GetDouble(reader.GetOrdinal("Quantity"));
                        pv.record_mealtotal[i] = reader.GetDouble(reader.GetOrdinal("MealTotal"));
                        i++;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void deleteRecords()
        {
            try
            {
                dbcon.OpenCon();
                string query = $"DELETE FROM Orders WHERE OrderID = {pv.orderID};";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void deleteCustomer()
        {
            // to delete customer with no records
            try
            {
                dbcon.OpenCon();
                string query = "DELETE FROM Customer WHERE CustomerID NOT IN(SELECT DISTINCT CustomerID FROM Orders);";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

    }
}
