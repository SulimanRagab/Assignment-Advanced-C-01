
#region Q01
//Q1: What is a generic class? Why use generics? 
//الgeneric class هي Class بتحدد نوع العامل بدل نوع بينات ثابت وبنسخدمها لأن ال generic class تقدر تتعامل مع اي نوع بينات مختلف بدل نوع بينات ثابت 
#endregion

#region Q03
// Q3:What are multiple type parameters? Write Pair<TKey,TValue >.
// ال  multiple type معناها ببساطه ان ال Class  تقدر تستخدم  اتنين او اكثر Type Parameter بدل Type Parameter واحد 
#endregion

#region Q04
// Q4: What is a generic method? Write Swap<T> method.
// ال Generic Method هيا ميثود بتستخدم معامل من نوع واحد مثال public static Metho<T>(T a) او اكثر من نوع ودا يخليها تقدر تتعامل مع اكثر من نوع بينات بدل نوع واحد ثابت  
//using Assignment_Advanced_C__01;
//int a = 1;
//int b = 2;
//Helper.Swap<int>(a, b);
#endregion

#region Q05
//using Assignment_Advanced_C__01;
// Q5: Write a generic method FindMax<T> that finds maximum value
//Console.WriteLine(Helper.FindMax<int>(20, 40)); 
#endregion

#region Q06
// Q6: What is a generic interface? Write `IRepository<T>`.
// ال generic interface هو interface  بيستخدم type parameter  بيسمح للميثود التعاملع مع انواع بينات مختلفه type parameterS
//using Assignment_Advanced_C__01;
//IRepository<order> or = new OrderRepository();
//or.Add(new order(1,"ahmed"));
//or.Add(new order(2,"Sulima"));
//or.Add(new order(3,"Mohamed"));
//or.Delete(1);
//or.printList();
//or.Delete(3);
//or.printList(); 
#endregion

#region Q07 Struct Constraint
//Q7: What is the 'struct' constraint? Write an example.
// Struct Constraint هو Constraint بيسمح فقط بدخول انواع ال Struct اللي هيا من نوع value Type زي int , duoble ,decimle مثال...
//using Assignment_Advanced_C__01;
//var p1= new ValueType<int>(1); // Ok
//var p2= new ValueType<double>(7.50); // Ok
//var p3= new ValueType<string>("Noo"); // No 
#endregion

#region Q08 Class Constraint
//Q8: What is the 'class' constraint? Write an example.
//Class Constraint هو قيد بيشرط استقبال Reference Type وليس value Type بيستقبل String , Array,class Type , Interface مثال ...
//using Assignment_Advanced_C__01;
//var c1 = new Repositoryclass<string>("Suliman");
//var c2 = new Repositoryclass<int[] >(new int[3]);
//c2.value[0] =1;
//c2.value[1] = 2;
//c2.value[2] = 3;
//foreach (var item in c2.value)
//{
//    Console.WriteLine(item);
//}
//var c3 = new Repositoryclass<order>(new order(1,"Ahmed"));
//Console.WriteLine(c3.value.Name);
//var p1= new Repositoryclass<int>(1); // No
//var p2= new Repositoryclass<double>(7.50); // No
#endregion

#region  Q09 new Constraint

//Q9: What is the 'new()' constraint? Write an example.
//new() constraint هو قيد بيسمح ب انشاء object  من <T> بشرط ان يكون ال <T> عنده Public Parameterless Constructor مثال ...
//using Assignment_Advanced_C__01;
//var c1 = Factore.CreateObject<order>(); // مسموح
//var c2 = Factore.CreateObject<ValueType>(); // غير مسموح لأن معندوش parameterless constructor 
#endregion

#region Q10 interface constraint
//Q10: What is the interface constraint? Write an example.
// ال Interface Constraint هو شرط بيشرط على ال T قبول ال Type اللي بتطبق Interface فقط مثال ...
//using Assignment_Advanced_C__01;
//using System.ComponentModel;
//var p1 = new order();
//var p2 = new Factore();
//var p3 = new Container();
//Printer.printitem(p1); //OK
//Printer.printitem(p2); //OK
//Printer.printitem(p3); // No 
#endregion

#region Q11
// Q11: What is the base class constraint?
// ال base class هو قيد بيشرط ان ال <T>  لازما تكون Classمعينه او كلاس وارثه منها  مثال ...
//using Assignment_Advanced_C__01;
//UpClass Class = new UpClass();
//DerivedClass1 c1 = new DerivedClass1();
//DerivedClass2 c2 = new DerivedClass2();
//baseclass.classbasec<UpClass>(Class);//ok
//baseclass.classbasec<DerivedClass1>(c1);//ok
//baseclass.classbasec<DerivedClass2>(c2); //Ok
//baseclass.classbasec<DerivedClass1>(c1);//ok
//baseclass.classbasec<DerivedClass2>(c2); //Ok
//baseclass.classbasec<order>(o1); // No
#endregion

#region Q12
// Q12: How do you apply multiple constraints? Write an example.
// ال multiple constraints هو ببساطه فرض اكثر من Constraint على نفس ال <T> مثال ...
//using Assignment_Advanced_C__01;
//order or = new order();
//baseclass.Multetype<order>(or); //Ok 
#endregion

#region Q13
// Q13: What does the 'default' keyword do in generics?
// وظيفة ال default في ال generics  استرجاع القيمه الافتراضيه لكل نوع بيناتdefault(T) 
#endregion

#region Q14
//Q14: Write a SafeList<T> that returns default when the index is invalid
//using Assignment_Advanced_C__01;
//SafeList<int> number = new SafeList<int>(new int[] {10,20,30});
//Console.WriteLine(number.Get(2)); // 30 saccessfuly
//Console.WriteLine(number.Get(10)); // defult 0 
#endregion
