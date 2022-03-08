using System;

int n100 =0,n50=0, n20=0, n10=0, n5=0, n2=0, m100=0, m50=0, m25=0, m10=0, m5=0, m1=0;
double convert, valor = double.Parse(Console.ReadLine());

if (valor > 0 && valor <= 1000000.00){
   if(valor >= 100.00){
        convert = valor / 100;
        n100 = (int)convert;
       valor =  valor % 100;
   }else{
       n100 = 0;
   }
   if(valor >= 50.00){
       convert = valor/50;
       n50 = (int)convert;
       valor =  valor % 50;
   }else{
       n50 = 0;
   }
   if(valor >= 20.00){
       convert = valor/20;
       n20 = (int)convert;
       valor =  valor % 20;
   }else{
       n20 = 0;
   }

   if(valor >= 10.00){
       convert = valor/10;
       n10 = (int)convert;
       valor =  valor % 10;
   }else{
       n10 = 0;
   }
   if(valor >= 5.00){
       convert = valor/5;
       n5 = (int)convert;
       valor =  valor % 5;
   }else{
       n5 = 0;
   }
   if(valor >= 2.00){
       convert = valor/2;
       n2 = (int)convert;
       valor =  valor % 2;
   }else{
       n2 = 0;
   }
   if(valor >= 1.00){
       convert = (int)valor;
       m100 = (int)convert;
       valor =  valor - convert;
   }else{
       m100 = 0;
   }
   if(valor >= 0.50){
       convert = (valor*100)/50;
       m50 = (int)convert;
       valor = ((valor*100) % 50)/100;
   }else{
       m50 = 0;
   }
   if(valor >= 0.25){
       convert = (valor*100)/25;
       m25 = (int)convert;
       valor = ((valor*100) % 25)/100;
   }else{
       m25 = 0;
   }
     if(valor >= 0.10){
       convert = (valor*100)/10;
       m10 = (int)convert;
       valor = ((valor*100) % 10)/100;
   }else{
       m10 = 0;
   }
     if(valor >= 0.05){
       convert = (valor*100)/5;
       m5 = (int)convert;
       valor = ((valor*100) % 5)/100;
   }else{
       m5 = 0;
   }
     if(valor >= 0.01){
       convert = (valor*100);
       m1 = (int)convert;
       valor = 0;
   }else{
       m1 = 0;
   }
}


Console.WriteLine("NOTAS:");
Console.WriteLine(n100+" nota(s) de R$ 100.00");
Console.WriteLine(n50+" nota(s) de R$ 50.00");
Console.WriteLine(n20+" nota(s) de R$ 20.00");
Console.WriteLine(n10+" nota(s) de R$ 10.00");
Console.WriteLine(n5+" nota(s) de R$ 5.00");
Console.WriteLine(n2+" nota(s) de R$ 2.00");
Console.WriteLine("MOEDAS:");
Console.WriteLine(m100+" moeda(s) de R$ 1.00");
Console.WriteLine(m50+" moeda(s) de R$ 0.50");
Console.WriteLine(m25+" moeda(s) de R$ 0.25");
Console.WriteLine(m10+" moeda(s) de R$ 0.10");
Console.WriteLine(m5+" moeda(s) de R$ 0.05");
Console.WriteLine(m1+" moeda(s) de R$ 0.01");
