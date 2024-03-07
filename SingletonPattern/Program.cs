using System;
using SingletonPattern;


Thread tr = new Thread(() => {
    var instance = UpService.GetUpService(1);
 });

Thread te = new Thread(() => {
    var instance = UpService.GetUpService(2);
});

tr.Start();
te.Start();

tr.Join();
te.Join();