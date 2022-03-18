double budget = 183.23;
double bagVolume = 64.11;
int people = 7;
int Npresents = 12;
double[] presentVolume = new double[Npresents];
double[] presentPrice = new double[Npresents];
presentVolume[0] = 4.53;
presentPrice[0] = 12.23;
presentVolume[1] = 9.11;
presentPrice[1] = 45.03;
presentVolume[2] = 4.53;
presentPrice[2] = 12.23;
presentVolume[3] = 6.00;
presentPrice[3] = 32.93;
presentVolume[4] = 1.04;
presentPrice[4] = 6.99;
presentVolume[5] = 0.87;
presentPrice[5] = 0.46;
presentVolume[6] = 2.57;
presentPrice[6] = 7.34;
presentVolume[7] = 19.45;
presentPrice[7] = 65.98;
presentVolume[8] = 65.59;
presentPrice[8] = 152.13;
presentVolume[9] = 14.14;
presentPrice[9] = 7.23;
presentVolume[10] = 16.66;
presentPrice[10] = 10.00;
presentVolume[11] = 13.53;
presentPrice[11] = 25.25;

double maxMoney = 0;


double[,] possiablites = new double[4096, 3];  //N P V
for (int i = 0; i < 4096 ; i++)
{
    string poss = Convert.ToString(i, 2);
    //Console.WriteLine(poss);
    for (int j = 0; j < poss.Length; j++) //0 0000 1000
    {
        if (poss[j] == '0') continue;
        possiablites[i, 0]++; //N
        possiablites[i, 1] += presentPrice[j];//P
        possiablites[i, 2] += presentVolume[j]; //V

    }
}

for (int i = 0; i < 4096; i++)
{

    if (possiablites[i, 0] % people == 0 && possiablites[i, 1] <= budget && possiablites[i, 2] <= bagVolume)
    {
        if (possiablites[i, 1] > maxMoney)
            maxMoney = possiablites[i, 1];
    }
}
Console.WriteLine(maxMoney);
