using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class OzelKuyruk
    {
        ArrayList sayilar=new ArrayList();
        public static int ElemanSayisi;
        public void Enqueue(int YeniEleman)
        {
            
            if(sayilar.Count==0)
            {
                sayilar.Add(YeniEleman);
                ElemanSayisi++;
            }
            else
            {
               
                if(YeniEleman%2==1)
                {
                    
                    for(int i=0;i<sayilar.Count;i++)
                    {
                        
                        if(Convert.ToInt32(sayilar[i])%2==0)
                        {
                            sayilar.Insert(i + 1, YeniEleman);
                            ElemanSayisi++;
                            break;
                        }
                        else
                        {
                        
                            sayilar.Add(YeniEleman);
                            ElemanSayisi++;
                            break;
                        }
                    }
                }
                else
                {
                   
                    for (int i = 0; i < sayilar.Count; i++)
                    {
                     
                        if (Convert.ToInt32(sayilar[i]) % 2 == 0)
                        {
                           
                            sayilar.Insert(i + 1, YeniEleman);
                            ElemanSayisi++;
                            break;
                        }
                        else
                        {
                            
                            sayilar.Add(YeniEleman);
                            ElemanSayisi++;
                            break;
                        }
                    }
                }
            }
        }

        public void Dequeue()
        {
            
            if (sayilar.Count != 0)
            {
                //eleman sayısı cift 
                if (sayilar.Count % 2 == 0)
                {
                  
                    sayilar.Remove(sayilar[sayilar.Count / 2]);
                    ElemanSayisi--;
                }
                else
                {
                   
                    sayilar.Remove(sayilar[(sayilar.Count + 1) / 2]);
                    ElemanSayisi--;
                 }
            }
            else
            {
               
                throw new BosKuyrukHatası();
            }
            
        }
        public void ElemanlariGoruntule()
        {
       
            for(int i=0;i<sayilar.Count;i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }

        
    }
}
