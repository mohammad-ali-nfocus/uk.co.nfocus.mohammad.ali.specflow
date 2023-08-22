Feature: ApplyCoupon
For checking User Features

 

  Scenario: Successful coupon application
    Given I have items in my cart
    And I am on the checkout page
    When I enter a valid coupon code for 15% off
    And I click the apply button
    Then I should see the discount applied to my total