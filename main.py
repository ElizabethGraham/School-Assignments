class ShippingCharges:
    """
    Python test of the ShippingCharges project
    """
    def calculate(package_weight):
        """
        If package weight is less than the key, 
        multiply package weight by the key's value.
        Elif handles packages over 10 pounds
        Else moves to the next key
        """
        weight_class = {2: 1.10, 6: 2.20, 10: 3.70}

        for i in weight_class:
            if package_weight <= i:
                print(package_weight * weight_class[i])  
            elif package_weight > 10: 
                print(package_weight * 3.80)  # Max charge
            else:
                continue


    def main():
        package_weight = int(input("Enter package weight: "))
        calculate(package_weight)


    if __name__ == '__main__':
        main()