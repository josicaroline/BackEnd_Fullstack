//fibonacci sequence

int aid1 = 0;
int aid2 = 1;
int fibo;

Console.WriteLine(1);
for(int i = 0; i < 20; i++) {
    fibo = aid1 + aid2;
    Console.WriteLine(fibo);
    aid1 = aid2;
    aid2 = fibo;
}


//array solution

int[] fibon = new int[20];
fibon[0] = 1;
fibon[1] = 1;

for(int i = 2; i < 20; i++) {
    fibon[i] = fibon[i-1] + fibon[i-2];
}

for(int i = 0; i < 20; i++) {
    Console.WriteLine(fibon[i]);
}