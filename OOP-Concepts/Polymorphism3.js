// 3. Polymorphism with Interfaces
// Though JavaScript doesn’t have formal interfaces like languages such as TypeScript or Java, 
// it can achieve a similar effect through object polymorphism.
// You can create different objects that share the same method names but have distinct implementations, 
// allowing them to be used interchangeably.

class PaymentProcessor {
    processPayment(amount) {
      console.log(`Processing payment of ${amount}`);
    }
  }
  
  class PayPalPayment extends PaymentProcessor {
    processPayment(amount) {
      console.log(`Processing PayPal payment of ${amount}`);
    }
  }
  
  class CreditCardPayment extends PaymentProcessor {
    processPayment(amount) {
      console.log(`Processing credit card payment of ${amount}`);
    }
  }
  
  class BitcoinPayment extends PaymentProcessor {
    processPayment(amount) {
      console.log(`Processing Bitcoin payment of ${amount}`);
    }
  }
  
  // Common interface for payment processing
  function processTransaction(paymentProcessor, amount) {
    paymentProcessor.processPayment(amount);
  }
  
  const paypal = new PayPalPayment();
  const creditCard = new CreditCardPayment();
  const bitcoin = new BitcoinPayment();
  
  // Polymorphic behavior: all objects follow the same interface
  processTransaction(paypal, 100);        
  processTransaction(creditCard, 200);    
  processTransaction(bitcoin, 300);       