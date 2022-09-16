using System;
class Program {

    public static void Main (string[]args) {
        //store_info
        int a; string b,c;
        a = input_money_for_open();
        b = input_store_name();
        c = input_location();
        store_info KFC1 = CreateKFC(a,b,c);
        print_store_info(KFC1);
        //ownerlist
        for (int z=0; z<3 ;z++){
        string d,e,f;
        d = input_owner_name();
        e = input_owner_surname();
        f = input_owner_id();
        owner_list owninfo = new owner_list(d,e,f);
        print_owner_list(owninfo);
        }
        //memberlist
        Console.WriteLine("Input number Member = ");
        int number_member = int.Parse(Console.ReadLine());
        for (int y=0; y<=number_member ;y++){
        string g,h,i,j,k;
        g = input_type_member();
        h = input_member_name();
        i = input_member_surname();
        j = input_member_years();
        k = input_member_salary();
        member_info meminfo = new member_info(g,h,i,j,k);
        print_member_info(meminfo);}

    } 
//store_info
    public static store_info CreateKFC (int KFC_money_for_open,string KFC_storename,string KFC_location){
        return new store_info(KFC_money_for_open,KFC_storename,KFC_location);
    }
    public static int input_money_for_open (){
        Console.Write("Input Money for open KFC =");
        string mfo = Console.ReadLine();
        if (int.TryParse(mfo ,out int number)){
            return number;
        }
        throw new Exception("Please input new Money for open KFC");
    }
    public static string input_store_name (){
        Console.Write("Input KFC Store name = ");
        return Console.ReadLine();
    }
    public static string input_location (){
        Console.Write("Input KFC location = ");
        return Console.ReadLine();
    }
    public static void print_store_info (store_info info){
        Console.WriteLine ("เงินทุนสำหรับการจดทะเบียนร้านค้า {0}",info.KFC_money_for_open);
        Console.WriteLine ("ชื่อสาขา {0}",info.KFC_storename);
        Console.WriteLine ("ที่อยู่ {0}",info.KFC_location);
    }

//owner_list
    public static owner_list ownerlist (string KFC_owner_name,string KFC_owner_surname,string KFC_owner_id){
        return new owner_list(KFC_owner_name,KFC_owner_surname,KFC_owner_id);
    }
    public static string input_owner_name (){
        Console.Write("Input Owner Name = ");
        return Console.ReadLine();
        }
    public static string input_owner_surname (){
        Console.Write("Input Owner Surname = ");
        return Console.ReadLine();
        }
    public static string input_owner_id (){
        Console.Write("Input Owner ID-Card = ");
        return Console.ReadLine();
    }

    public static void print_owner_list (owner_list info){
        Console.WriteLine("Your owner name is = {0} {1}",info.KFC_owner_name,info.KFC_owner_surname);
        Console.WriteLine("Your owner id is = {0}",info.KFC_owner_id);
    }
    //member_info
    public static member_info memberlist (string KFC_type_member,string KFC_member_name,string KFC_member_surname,string KFC_member_years,string KFC_member_salary){
        return new member_info(KFC_type_member,KFC_member_name,KFC_member_surname,KFC_member_years,KFC_member_salary);
    }
    public static string input_type_member(){
        Console.Write("Your Type = ");
        return Console.ReadLine();
    }
    public static string input_member_name(){
        Console.Write("Your member Name = ");
        return Console.ReadLine();
    }
    public static string input_member_surname(){
        Console.Write("Your surname = ");
        return Console.ReadLine();
    }
    public static string input_member_years(){
        Console.Write("Your years = ");
        return Console.ReadLine();
    }
    public static string input_member_salary(){
        Console.Write("Your salary = ");
        return Console.ReadLine();
    }
    public static void print_member_info (member_info info){
        Console.WriteLine("Your member type is = {0}",info.KFC_type_member);
        Console.WriteLine("Your member name is = {0} {1}",info.KFC_member_name,info.KFC_member_surname);
        Console.WriteLine("Your age is = {0}",info.KFC_member_years);
        Console.WriteLine("Your salary is = {0}",info.KFC_member_salary);
    }
    //KFC_calculate
    public static double input_sell_order(){
        Console.Write("Sell order = ");
        string sellord = Console.ReadLine();
        if (double.TryParse(sellord ,out double number)){
            return number;
        }
        throw new Exception("Pleast input int order");
    }
    public static double input_delivery_order(){
        Console.Write("Delivery order = ");
        string deord = Console.ReadLine();
        if (double.TryParse(deord ,out double number)){
            return number;
        }
        throw new Exception("Pleast input int delivery order");
    }

}