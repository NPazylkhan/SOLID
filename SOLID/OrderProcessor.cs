namespace SOLID
{
    /// <summary>
    /// Single Responsibility Principle
    /// Open/Closed Principle
    /// Interface Segregation Principle
    /// Dependency Inversion Principle
    /// </summary>
    public class OrderProcessor
    {
        private readonly OrderValidator orderValidator;
        private readonly IOrderSaver[] orderSaver;
        private readonly OrderNotificationSender orderNotificationSender;

        public OrderProcessor(OrderValidator orderValidator, IOrderSaver[] orderSaver, OrderNotificationSender orderNotificationSender)
        {
            this.orderValidator = orderValidator;
            this.orderSaver = orderSaver;
            this.orderNotificationSender = orderNotificationSender;
        }

        public void Process()
        {
            orderValidator.Validate();
            foreach (var item in orderSaver)
            {
                item.Save(null);
            }
            orderNotificationSender.SendNotification();
        }
    }


    #region Interfaces
    public interface IOrderSaver
    {
        void Save(string order);
    }

    public interface IOrderDeleter
    {
        void Delete(int id);
    }
    
    public interface IOrderReader
    {
        string Read(int id);
    }
    #endregion

    #region Classes
    public class OrderValidator
    {
        public void Validate() { }
    }

    public class DbOrderSaver : IOrderSaver
    {
        public void Save(string order) { }
    }

    public class CacheOrderSaver : IOrderSaver
    {
        public void Save(string order) { }
    }

    public class OrderNotificationSender
    {
        public void SendNotification() { }
    }
    #endregion
}
