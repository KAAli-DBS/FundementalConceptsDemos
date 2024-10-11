//2. Using Factory Functions (Functional Abstraction)
//You can also use factory functions to create objects that encapsulate internal details while exposing 
//a simpler interface.

function createPhone(model, batteryLife) {
    let battery = batteryLife;
  
    // Internal function
    function useBattery() {
      battery -= 1;
      if (battery < 0) {
        console.log("Battery dead!");
      }
    }
  
    // Public interface
    return {
      call: function() {
        if (battery > 0) {
          console.log("Making a call...");
          useBattery();
        } else {
          console.log("Cannot make a call, battery dead!");
        }
      },
      getBatteryLife: function() {
        return battery;
      }
    };
  }
  
  const myPhone = createPhone("iPhone", 5);
  myPhone.call(); 
  console.log(myPhone.getBatteryLife()); 
  //myPhone.useBattery(); 