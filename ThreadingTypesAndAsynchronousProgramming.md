# Tekli İş Parçacığı — Çoklu İş Parçacığı ve Asenkron Programlama (Single — Multi Threading and Asynchronous Programming)


</br></br>


## Tekli İş Parçacığı (Single Threading)
___“Tekli İş Parçacığı (Single Threading)”___ özetle; bir işlem bir threadi kullanırken, başka bir işlemin aynı threadi kullanamamasıdır. 
Diğer işlemin aynı threadi kullanabilmesi için, mevcut durumda threadi kullanan işlemin bitmesi gerekir. İşte bu duruma da ___“Tekli İş Parçacığı (Single Threading)”___ denir.

![SingleThreading](https://github.com/eenesyalcin/CSharp-Basics/assets/107759141/e4c5683b-0d44-4dd2-bb93-f9a6c825b5a5)

Yukarıdaki şemada İŞLEM-1 threadi kullanmaktadır. İŞLEM-2'nin threadi kullanabilmesi için İŞLEM-1'in bitmesini beklemektedir. İŞLEM-1 bittikten sonra İŞLEM-2 threadi kullanabilecektir.


</br></br>


## Çoklu İş Parçacığı (Multi Threading)
___“Muti Threading”___ özetle; bir işlem gerçekleştirilirken diğer bir işlemin sırada beklemesi yerine eş zamanlı olarak görev yapabilmesi için, başka bir threadi kullanmasına denir.
___“Çoklu İş Parçacığı (Multi Threading)”___ kullanımı söz konusuyken genellikle verimli bir program elde edilebilmesi için thread sayısı 8'i geçmez. 
Eğer thread sayısından fazla işlem sayısı varsa 8 taneden sonraki işlemler için tekrar ___“Tekli İş Parçacığı (Single Threading)”___ durumu söz konusu olur. 
Yani herhangi bir thread boşa çıkana kadar işlem bekler ve bir thread boşa çıktığında gerçekleştirilmesi gereken işlem o threade yapışır. 
Ayrıca toplam 8 taneden oluşan thread kümesine thread havuzu anlamına gelen ___“İş Parçacığı Havuzu (Thread Pool)”___ denir.

![MultiThreading](https://github.com/eenesyalcin/CSharp-Basics/assets/107759141/93e2388f-4181-4285-bf1d-de0e89c5718b)

Yukarıdaki şemada 9 tane işlem ve 8 tane thread vardır. Her thread bir işlem tarafından kullanılmaktadır. Boşta olan İŞLEM-9, THREAD-7'nin işini ilk bitirdiğini varsayarsak hemen ona yapışır ve 
onu kullanmaya başlar. Yani 8 tane ile sınırlandırılmış olan ___“Çoklu İş Parçacığı (Multi Threading)”___ söz konusu ise, 8. işlemden sonra bu durum ___“Single Threading (Tekli İş Parçacığı)”___ durumuna döner.


</br></br>


## Asenkron Programlama (Asynchronous Programming)
___“Asynchronous Programming (Asenkron Programlama)”___ özetle; iki işlemin eş zamanlı olarak aynı threadi kullanabilmesine denir.

![AsynchronousProgramming](https://github.com/eenesyalcin/CSharp-Basics/assets/107759141/052038aa-a01f-4d3d-8d4a-54d82cda1550)

Yukarıdaki şemada İŞLEM-1 threadi kullanmaya başlamıştır. Eş zamanlı olarak İŞLEM-2 de aynı threadi kullanmaktadır. 
Ayrıca ___“Asynchronous Programming (Asenkron Programlama)”___ da iki işlem aynı threadi; aynı zamanda ve aynı şekilde(konumda) kullanabilirler.


</br><hr>


Eğer yazımı Medium hesabımdan okumak ve destek vermek isterseniz aşağıdaki linki ziyaret edebilirsiniz. </br>
***https://medium.com/@eenes.ylcn/single-thrading-multi-threading-ve-asenkron-programlama-306d0d6dbbc1*** <hr>
