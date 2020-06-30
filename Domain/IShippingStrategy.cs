namespace Domain.Interfaces {
    public interface IShippingStrategy {
        double Calculate(Order order);
    }
}
