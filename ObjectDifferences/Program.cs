using System;

namespace ObjectDifferences
{
    public class Program
    {
        public static void Main()
        {
            var foo1 = new Foo(3, 1, new Foo.Bar(5, 1));
            var foo2 = new Foo(1, 3, new Foo.Bar(1, 5));
            var res = Comparer.Compare(foo1, foo2);
            if (res.Count == 0)
            {
                Console.WriteLine($"{nameof(foo1)} and {nameof(foo2)} are equal");
            }
            foreach (var diff in res)
            {
                Console.WriteLine($"Property Name : {diff.Name} \n Val for {nameof(foo1)} : {diff.Val1} \n Val for {nameof(foo2)} : {diff.Val2}");
            }

            var baz1 = new Foo.Baz(1, 3);
            var baz2 = new Foo.Baz(1, 1);
            var res2 = Comparer.Compare(baz1, baz2);
            if (res.Count == 0)
            {
                Console.WriteLine($"{nameof(baz1)} and {nameof(baz2)} are equal");
            }
            foreach (var diff in res2)
            {
                Console.WriteLine($"Property Name : {diff.Name} \n Val for {nameof(baz1)} : {diff.Val1} \n Val for {nameof(baz2)} : {diff.Val2}");
            }
        }
    }
}
