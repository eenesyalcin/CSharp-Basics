# Tekli Ýþ Parçacýðý — Çoklu Ýþ Parçacýðý ve Asenkron Programlama (Single — Multi Threading and Asynchronous Programming)


</br></br>


## Tekli Ýþ Parçacýðý (Single Threading)
___“Tekli Ýþ Parçacýðý (Single Threading)”___ özetle; bir iþlem bir threadi kullanýrken, baþka bir iþlemin ayný threadi kullanamamasýdýr. 
Diðer iþlemin ayný threadi kullanabilmesi için, mevcut durumda threadi kullanan iþlemin bitmesi gerekir. Ýþte bu duruma da ___“Tekli Ýþ Parçacýðý (Single Threading)”___ denir.

![SingleThreading](https://github.com/eenesyalcin/fdfd/assets/107759141/20eea127-246a-4d55-9df5-2b257d9202fa)

Yukarýdaki þemada ÝÞLEM-1 threadi kullanmaktadýr. ÝÞLEM-2'nin threadi kullanabilmesi için ÝÞLEM-1'in bitmesini beklemektedir. ÝÞLEM-1 bittikten sonra ÝÞLEM-2 threadi kullanabilecektir.


</br></br>


## Çoklu Ýþ Parçacýðý (Multi Threading)
___“Muti Threading”___ özetle; bir iþlem gerçekleþtirilirken diðer bir iþlemin sýrada beklemesi yerine eþ zamanlý olarak görev yapabilmesi için, baþka bir threadi kullanmasýna denir.
___“Çoklu Ýþ Parçacýðý (Multi Threading)”___ kullanýmý söz konusuyken genellikle verimli bir program elde edilebilmesi için thread sayýsý 8'i geçmez. 
Eðer thread sayýsýndan fazla iþlem sayýsý varsa 8 taneden sonraki iþlemler için tekrar ___“Tekli Ýþ Parçacýðý (Single Threading)”___ durumu söz konusu olur. 
Yani herhangi bir thread boþa çýkana kadar iþlem bekler ve bir thread boþa çýktýðýnda gerçekleþtirilmesi gereken iþlem o threade yapýþýr. 
Ayrýca toplam 8 taneden oluþan thread kümesine thread havuzu anlamýna gelen ___“Ýþ Parçacýðý Havuzu (Thread Pool)”___ denir.

![MultiThreading](https://github.com/eenesyalcin/fdfd/assets/107759141/1a873bcd-bd1d-481c-9a44-15e1852663e7)

Yukarýdaki þemada 9 tane iþlem ve 8 tane thread vardýr. Her thread bir iþlem tarafýndan kullanýlmaktadýr. Boþta olan ÝÞLEM-9, THREAD-7'nin iþini ilk bitirdiðini varsayarsak hemen ona yapýþýr ve 
onu kullanmaya baþlar. Yani 8 tane ile sýnýrlandýrýlmýþ olan ___“Çoklu Ýþ Parçacýðý (Multi Threading)”___ söz konusu ise, 8. iþlemden sonra bu durum ___“Single Threading (Tekli Ýþ Parçacýðý)”___ durumuna döner.


</br></br>


## Asenkron Programlama (Asynchronous Programming)
___“Asynchronous Programming (Asenkron Programlama)”___ özetle; iki iþlemin eþ zamanlý olarak ayný threadi kullanabilmesine denir.

![AsynchronousProgramming](https://github.com/eenesyalcin/fdfd/assets/107759141/540cc976-9c6a-4333-aba1-8b8e71679501)

Yukarýdaki þemada ÝÞLEM-1 threadi kullanmaya baþlamýþtýr. Eþ zamanlý olarak ÝÞLEM-2 de ayný threadi kullanmaktadýr. 
Ayrýca ___“Asynchronous Programming (Asenkron Programlama)”___ da iki iþlem ayný threadi; ayný zamanda ve ayný þekilde(konumda) kullanabilirler.


</br><hr>


Eðer yazýmý Medium hesabýmdan okumak ve destek vermek isterseniz aþaðýdaki linki ziyaret edebilirsiniz. </br>
***https://medium.com/@eenes.ylcn/single-thrading-multi-threading-ve-asenkron-programlama-306d0d6dbbc1*** <hr>