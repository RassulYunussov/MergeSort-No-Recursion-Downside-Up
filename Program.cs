using System;
using System.Collections.Generic;
using System.Linq;

namespace tt
{
  
    class Program
    {
        static void MergeSort(int [] src)
        {
            int [] buff = new int [src.Length];
            for(int i = 1;i<=src.Length;i*=2)
            {
                for(int j = 0;j+i<src.Length;j+=i*2)
                {
                    int mid = j+i;
                    int right = mid+i;
                    if(right>src.Length)
                        right = src.Length;
                    int ii=j,jj=mid,kk=0;
                    while(ii<mid&&jj<right)
                    {
                        if(src[ii]<src[jj])
                            buff[kk++]=src[ii++];
                        else
                            buff[kk++]=src[jj++];
                    }
                    if(ii<mid)
                        Buffer.BlockCopy(src,ii*sizeof(int),buff,kk*sizeof(int),(mid-ii)*sizeof(int));
                    if(jj<right)
                        Buffer.BlockCopy(src,jj*sizeof(int),buff,kk*sizeof(int),(right-jj)*sizeof(int));
                    Buffer.BlockCopy(buff,0,src,j*sizeof(int),(right-j)*sizeof(int));
                }
            }

        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int [] a = Enumerable.Range(1,1000)
                                .Select(x=>r.Next(1,1000))
                                .ToArray();
            MergeSort(a);
        }
    }
}
