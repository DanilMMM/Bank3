using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Bank
{

    
    public int Ncheta;
    public string FIO;
    public float sum;
    public int vibor;

    

    public  Bank (string FIO, int Ncheta, float sum)
    {
        this.FIO = FIO;
        this.Ncheta = Ncheta; 
        this.sum = sum;
    }  
    public void Out()           
    {
        Console.WriteLine($"Номер счета {Ncheta} \nВладелец счета {FIO}  \nКол-во средств на счету {sum}");
           
    }
                                                                                                                                                                       
    public void Dob(float sum)
    {
        float perv = this.sum;                          
        Console.WriteLine($"Кол-во денег на счету {perv} \nПополнить счет на {sum} ?");
        sum = perv + sum;
        Console.WriteLine($"Ваш баланс {sum}");
    } 
    public void umen (float sum)
    {
        float perv = this.sum;
        Console.WriteLine($"Кол-во денег на счету {perv} \nСнять со счета {sum} ?");
        sum = perv - sum;
        Console.WriteLine($"Ваш баланс {sum}");
    }

    public void obnul(float sum)                                                                                                                                                
    {
        sum = sum;
        Console.WriteLine($"Снять со счета все средства ?");
        sum = sum - sum;
        Console.WriteLine($"Баланс {sum}");
    }

   // public void Perevod (float per)
  //  {
  //////////////////////////////////////  ////////////////////////////////////     
     //   Console.WriteLine($"Введите сумму которую хотите перевести ");
       // Console.ReadLine();
       // sum = sum - per;
        //Console.WriteLine($"Ваш баланс {sum} ");

   // }

    public void Perevod (Bank bank)
    {
        Console.WriteLine($"Сколько вы хотите перевести руб. на счёт {bank.Ncheta}");
        float Amount = Convert.ToSingle(Console.ReadLine());

        if (sum >= Amount)
        {
            bank.sum += Amount;
            sum -= Amount;
            Console.WriteLine($"Перевод на счёт {bank.Ncheta} выполнен успешно");
        }
        else
        {
            Console.WriteLine("Недостаточно средств для перевода");
        }
    }


    public void Syst(Bank bank)
    {
        int proverka = 0;
        do
        {
            Console.WriteLine("Нажмите 0 если хотите выйти из приложения банка\nНажмите 1 если хотите пополнить счёт.\nНажмите 2 если хотите снять деньги со счёта\nНажмите 3 если хотите снять все деньги со счёта\nНажмите 4 если хотите перевести деньги на другой счёт");
            string vibor = (Console.ReadLine());
            switch (vibor)
            {
                case "1" :
                    Dob(9965906);
                    break;
                case "2" :
                    umen(9876);
                    break;
                case "3" :
                    obnul(2345);
                    break;
                case "4" :
                    Perevod(bank);
                    break;
                case "0" :
                    proverka++;
                    break;
                default:
                    Console.WriteLine("Ни одна операция не выполнена");
                    break;
            }
        }
        while (proverka == 0);
    }


















}




