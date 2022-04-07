var TicktsModule = require("../Modules/FlightTicketModule");

var Ticket1 = TicktsModule.CreateTicket(125,50,"Cairo","London","25/4/2023");
console.log(TicktsModule.displayTicket(Ticket1));

var Ticket1 = TicktsModule.getTicket(Ticket1);
console.log(Ticket1.SeatNum);

TicktsModule.UpdateTicketDepatual(Ticket1.id,"Inda");
console.log(TicktsModule.displayTicket(Ticket1.id));

var Ticket2 = TicktsModule.CreateTicket(75,3,"UK","US","25/4/2003");
console.log(TicktsModule.displayTicket(Ticket2));


