mermaid.md
```mermaid
classDiagram

class CashPaymentStrategy
CashPaymentStrategy : +Pay() Void

class CreditCardPaymentStrategy
CreditCardPaymentStrategy : +Pay() Void

class DebitCardPaymentStrategy
DebitCardPaymentStrategy : +Pay() Void

class IPaymentStrategy
IPaymentStrategy : +Pay() Void

class PaymentContext
PaymentContext : +SetPaymentStrategy() Void
PaymentContext : +ProcessPayment() Void


IPaymentStrategy <|.. CashPaymentStrategy
IPaymentStrategy <|.. CreditCardPaymentStrategy
IPaymentStrategy <|.. DebitCardPaymentStrategy

```
