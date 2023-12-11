namespace backbone
{
    public static class PublicVariables
    {
        /*  
            BSIT 2101 - GROUP 12
                ALOCILLO, MELVIN DARYLL
                JOSE, PRINCESS MIKHAELA
                MACATANGAY, KEITH CARLO
                VELASQUEZ, KEN ANGELO
         
            IMPORTANT NOTE: 
            MAKE SURE TO REPLACE FOLDER
            PATH AND DATABASE NAME TO AVOID
            ERRORS ON THE SYSTEM, ENJOY!

           You can access the path by:
         - Right clicking the folder "files".
         - Click "copy full path"
         - Paste on the folderPath

          For database, you may access the
          "query.txt" and paste it on the 
          phpmyAdmin. You may use "XAMPP" to
          access the "localhost/phpmyAdmin/"
          on any browser
        */

        // Connections and Folderpaths

        public static string folderPath = "paste_your_path_here";
        public static string dbname = "finals_db";

        // Imported Font
        public static string font = $"{folderPath}font\\Jellee-Roman.ttf";


        // Customer Info
        public static string customerName = "";
        public static string customerAddress = "";
        public static string customerContact = "";

        // Item Info
        public static int[] itemID = new int[0];
        public static string[] itemName = new string[0];
        public static double[] itemPrice = new double[0];
        public static string[] itemDescription = new string[0];
        public static bool[] itemAvailability = new bool[0];
        public static int indexItem; // for orderitem and view order

        // For Transaction
        public static double[] itemQuantity = new double[0];
        public static double[] mealTotal = new double[0];
        public static double totalBill; // can also use on admin
        public static double totalQuantity;
        public static string paymentMethod = "";
        public static double paymentAmount; // can also use on admin
        public static double changeAmount; // can also use on admin
        public static string date = "";

        // For Checking
        public static int customerID;
        public static bool isNewCustomer = false;
        public static int orderID; // can also use on admin


        // FOR ADMIN
        // ACCOUNT
        public static string username = "";
        public static string password = "";
        public static string verification = "";

        // ITEM
        public static int adminItemIndex;
        public static double currentPrice;


        // RECORDS
        public static int[] record_itemID = new int[0];
        public static string[] record_itemName = new string[0];
        public static double[] record_quantity = new double[0];
        public static double[] record_mealtotal = new double[0];
    }

}
