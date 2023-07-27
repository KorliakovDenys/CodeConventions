namespace CodeConventions {
    public interface INameOfInterface {
        public void DoSomethingThree(int parameter);

        public int GetSomethingThree(int parameter);

        public Task DoSomethingThreeAsync(int parameter);

        public Task<int> GetSomethingThreeAsync(int parameter);
    }
}