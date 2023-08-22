Feature: Login and add item to cart
For checking User Features

 

 Scenario: Successful login
    Given I am on the login page
    When I enter my valid username and password
    And I click the login button
    Then I should be logged in


Scenario: Add item to cart
    Given I should be logged in
    And I am on the Shop page
    When I select a item 
    And I add it to the cart
    Then When i view the cart the item should be there