namespace CodeConventions {
    public class NameOfClass : INameOfInterface {
        private static int _privateStaticVariable = 123;

        private const int PrivateConstantVariable = 123;

        private readonly int _privateReadOnlyVariable = 123;

        private int _privateVariable = 123;

        private int PrivateVariableProperty {
            get => _privateVariable;
            set {
                _privateVariable = value;
                Console.WriteLine("*sample text*");
            }
        }

        protected static int ProtectedStaticVariable = 123;

        protected const int ProtectedConstantVariable = 123;

        protected readonly int ProtectedReadOnlyVariable = 123;

        protected int ProtectedVariable = 123;

        protected int ProtectedVariableProperty {
            get => ProtectedVariable;
            set {
                ProtectedVariable = value;
                Console.WriteLine("*sample text*");
            }
        }

        public static int PublicStaticVariableOne = 123;

        public const int PublicConstantVariable = 123;

        public readonly int PublicReadOnlyVariable = 123;

        public int PublicVariable = 123;

        public int PublicVariableProperty {
            get => PublicVariable;
            set {
                PublicVariable = value;
                Console.WriteLine("*sample text*");
            }
        }

        private void DoSomethingOne() { }

        private int GetSomethingOne() {
            return 123;
        }

        protected void DoSomethingTwo() { }

        protected int GetSomethingTwo() {
            return 123;
        }

        public void DoSomethingThree(int parameter) { }

        public int GetSomethingThree(int parameter) {
            return parameter;
        }

        private async Task DoSomethingOneAsync() {
            await Task.Delay(1000);
        }

        private async Task<int> GetSomethingOneAsync() {
            await Task.Delay(1000);

            return 123;
        }

        protected async Task DoSomethingTwoAsync() {
            await Task.Delay(1000);
        }

        protected async Task<int> GetSomethingTwoAsync() {
            await Task.Delay(1000);

            return 123;
        }

        public async Task DoSomethingThreeAsync(int parameter) {
            await Task.Delay(1000);
        }

        public async Task<int> GetSomethingThreeAsync(int parameter) {
            await Task.Delay(1000);

            return parameter;
        }
    }
}