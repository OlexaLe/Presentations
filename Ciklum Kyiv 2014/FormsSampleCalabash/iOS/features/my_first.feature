Feature: Calabash demo
  
Scenario: Magic should work
  Given I clear input field number 1

  When I enter "Xamarin" into input field number 1
  And I touch the "Do Magic" button
  
  Then I wait to see "niramaX"
