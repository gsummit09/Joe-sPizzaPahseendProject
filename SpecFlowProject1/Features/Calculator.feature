Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: pizza order should be placed by me
	Given i have to navigate to home page
	Then click on list pizza and add pizza to cart
	Then click order button and add pizza to cart
	Then click on order  butoon to check order list
	Then add  pizzas and payment
	When click on checkout button order should be placed