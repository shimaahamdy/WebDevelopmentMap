int[] arr;
int maxDistance = -1;
int N = int.Parse(Console.ReadLine());
arr = new int[N];
for (int i = 0; i < N; i++)
    arr[i] = int.Parse(Console.ReadLine());
    
for(int i = 0; i < N;i++)
{
    int first = Array.IndexOf(arr, arr[i]);
    int last = Array.LastIndexOf(arr, arr[i]);
    int dis = last - first-1;
    if (dis > maxDistance)
        maxDistance = dis;
}
Console.WriteLine(maxDistance);

