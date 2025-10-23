public void processOrder(Order order) {
    if (order == null || order.getItems().isEmpty()) {
      throw new IllegalArgumentException("Order is invalid.");
    }
  
    double totalPrice = 0.0;
    for (Item item : order.getItems()) {
      totalPrice += item.getPrice() * item.getQuantity();
    }
    order.setTotalPrice(totalPrice);
  
    if (totalPrice > 0) {
      order.setStatus("Processed");
    } else {
      order.setStatus("Pending");
    }
  
    System.out.println("Order for customer " + order.getCustomerName() + " has been processed. Total price: " + totalPrice);
  }