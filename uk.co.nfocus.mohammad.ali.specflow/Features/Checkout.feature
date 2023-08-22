Feature: Checkout
For checking User Features

 

Scenario: Successful checkout
    Given I am logged in and have added items in my cart
    And I click checkout
    When I enter my shipping and payment information
    And I click the complete order button
    Then I should see a confirmation page with my order details
