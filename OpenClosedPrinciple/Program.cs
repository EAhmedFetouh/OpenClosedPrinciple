

/*
 Open/Closed Principle:-
"Classes should be open for extension, but closed for modification.
" That means we should be able to add new functionality without changing existing code.
 */


using OpenClosedPrinciple.OpenClosed;

var service = new NewDiscountService(new EnterpriseDiscount());
Console.WriteLine(service.CalculateTotal(1000)); 

