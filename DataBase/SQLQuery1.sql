--Query1:بیمار با نام محمد اریامنش به چه علت بستری شده ایا جراحی داشته و چه تاریخی مرخص شده
select S_type,Jarahi,Free from Sick
where S_name=N'محمد اریامنش'



--Query2:ایا بیمار با نام هانیه تورانی در بیمارستان پذیرش شده است
select S# from Sick
where S_name=N'هانیه تورانی'



--Query3:پزشک معالج داریوش بانی کیست
select  Doctor.Dr_name from Sick,Doctor
where Sick.Dr#=Doctor.Dr# and Sick.S_name=N'داریوش بانی'



--Query4:اسامی تمام پزشکان جراح در این مرکزو نام بخش فعالیت
select Doctor.Dr_name,Part.Part_name from Doctor,Part
where Doctor.Part#=Part.Part# and Doctor.Dr_master=N'جراح'



--Query5:جراحی بیماران در این مرکز توسط کدام پزشکان انجام شده است
select Doctor.Dr_name,Sick.S_name from Doctor,Sick
where Doctor.Dr#=sick.Dr# and Jarahi<>null



--Query6:نام رییس هر بخش و تخصص او را نشان دهید
select Part.Part_maneger,Doctor.Dr_master from Doctor,Part
where Doctor.Part#=Part.Part# and Doctor.Dr_name=Part.Part_maneger



--Query7:نام تمام بیماران بستری و شماره ی تخت ان هاو علت بستری
select Sick.S_name,Bed.Bed#,Sick.S_type from Sick,Bed
where Sick.S#=Bed.S#



--Query8:اسامی بیمارانی که بدهی انها کمتر 750است
select Sick.S_name from Sick,Cash
where Sick.S#=Cash.S# and Cash.Bedehi<750



--Query9:به کسانی که به این مرکز مراجعه داشته اند 10درصد تخفیف بدهید
insert into Cash (Cash#,S#,Bedehi,Total)
select Cash.Cash#, Sick.S#,Cash.Bedehi-0.1*Cash.Total,Cash.Total from Sick,Cash
where Sick.S#=Cash.S#



--Query10:به افرادی که بیمه ی ملت دارند 40درصد تخفیف بدهید
insert into Cash (Cash#,S#,Bedehi,Total)
select Cash.Cash#, Sick.S#,Cash.Bedehi-0.4*Cash.Total,Cash.Total from Sick,Cash
where Sick.S#=Cash.S# and Sick.Bemeh=N'ملت'