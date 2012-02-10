The DatePicker has a Date property, but its value is always low by 1 day.

When you select e.g. 2012-01-01 it has value 2011-12-31.

The value displayed on the picker is correct, but the Date Property is wrong.

This can easily be demonstrated with this little project.

Whenever the DatePicker is changed, the current Date value is written to the console.

This little demo only demonstrates the problem for UIDatePickerMode.Date cases.

But the two other modes can also be tested by fiddling with the comments on the mode lines.

UIDatePickerMode.DateAndTime and UIDatePickerMode.Time pickers have the hour field low by one hour.

I detected this problem with the latest 5.2.x MT, but it may well be inherited from previous versions.


_Update_

As Jackson Harper pointed out in the monotouch mailing list, this Date property
is in UTC.

My local time is UTC+1, so the reported date is midnight - 1 hour, ergo the
previous day.

Sorry for the noise.