// // Тип 1. Ничего не принимает, ничего не возвращает

// void Method1(){
//     Console.WriteLine("Hello World");
// }

// // чтобы вызвать:
// // Method1();


// //-----------------------------------------------------

// // Тип 2. Принимает, но не возвращает

// void Method2(string msg){
//     Console.WriteLine(msg);
// }

// // чтобы вызвать:
// // Method2("Hello World");


// //-----------------------------------------------------


// // Тип 3. Возвращают, но не принимают

// int Method3(){
//     return DateTime.Now.Year;
// }

// //чтобы вызвать:
// // int year = Method3();
// // Console.WriteLine(year);


// //-----------------------------------------------------


// // Тип 4. Принимают и возвращают

// string Method4 (int count, string text){
//     int i = 0;
//     string result = String.Empty;
//     while(i < count){
//         result = result + text;
//         i++;
//     }
//     return result;

// }

// // чтобы вызвать:
// // string res = Method4(10, "david");
// // Console.WriteLine(res);