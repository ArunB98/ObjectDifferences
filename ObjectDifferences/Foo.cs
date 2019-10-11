namespace ObjectDifferences
{
    public sealed class Foo
    {
        public int prop1 { get; set; }
        public int prop2 { get; set; }

        public Bar bar { get; set; }

        public Foo(int prop1, int prop2, Bar bar)
        {
            this.prop1 = prop1;
            this.prop2 = prop2;
            this.bar = bar;
        }
       public sealed class Bar
        {
            public int prop3 { get; set; }
            public int prop4 { get; set; }

            public Bar(int prop3, int prop4)
            {
                this.prop3 = prop3;
                this.prop4 = prop4;
            }
        }

        public sealed class Baz
        {
            public int prop5 { get; set; }
            public int prop6 { get; set; }

            public Baz(int prop5, int prop6)
            {
                this.prop5 = prop5;
                this.prop6 = prop6;
            }
        }
    }
}
