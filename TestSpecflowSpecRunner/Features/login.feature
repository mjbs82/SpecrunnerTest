@REQ_BESTSECRET-37487
Feature: login
#-------------------------------------------------------------
@id:3
Scenario: Logging in with invalid username
  Given I am on the Corazon login page
  When I login with wrong credentials
  Then the login is not successfully done
  