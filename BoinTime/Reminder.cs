using System;

namespace BoinTime {

    public enum ReminderType {
        hourly,
        daily,
        weekly,
        monthly,
        yearly,
        every,
        once
    }

    public enum CustomType {
        minutes,
        hours,
        days,
        weeks,
        months,
        years
    }

    public class Reminder : IComparable<Reminder> {
        public string description { get; set; }
        public ReminderType type { get; set; }
        public DateTime date { get; set; }

        public CustomType customType { get; set; }
        public int customValue { get; set; }

        public bool showNotification { get; set; }
        public int notificationMins { get; set; }
        public bool notificationShown { get; private set; }

        public bool expired { get; private set; }
        

        public Reminder(string description, ReminderType type, DateTime date, 
            CustomType customType = CustomType.minutes, int customValue = 45,
            bool showNotification = false, int notificationMins = 30) 
        {
            this.description = description;
            this.type = type;
            this.date = date;
            this.customType = customType;
            this.customValue = customValue;
            this.showNotification = showNotification;
            this.notificationMins = notificationMins;
            this.notificationShown = false;
            this.expired = false;
        }

        public TimeSpan timeRemaining() {
            return timeRemaining(DateTime.Now);
        }

        public TimeSpan timeRemaining(DateTime fromDate) {
            var oldDate = new DateTime(date.Ticks); // copy this.date

            // while this.date has passed fromDate, set this.date to the next date based on this.type
            // ex: fromDate is 1/3/17 and we have a daily reminder that's date property is 1/1/17
            // if we just added a day to the date, it would still be in the past, so we add days until it isn't
            while (!expired && (fromDate - date).TotalMilliseconds <= 0) {
                if (type == ReminderType.once) {
                    expired = true;
                } else if (type == ReminderType.hourly) {
                    date.AddHours(1);
                } else if (type == ReminderType.daily) {
                    date.AddDays(1);
                } else if (type == ReminderType.weekly) {
                    date.AddDays(7);
                } else if (type == ReminderType.monthly) {
                    date.AddMonths(1);
                } else if (type == ReminderType.yearly) {
                    date.AddYears(1);
                } else { // custom (or 'every')
                    if (customType == CustomType.minutes) {
                        date.AddMinutes(customValue);
                    } else if (customType == CustomType.hours) {
                        date.AddHours(customValue);
                    } else if (customType == CustomType.days) {
                        date.AddDays(customValue);
                    } else if (customType == CustomType.weeks) {
                        date.AddDays(customValue * 7);
                    } else if (customType == CustomType.months) {
                        date.AddMonths(customValue);
                    } else if (customType == CustomType.years) {
                        date.AddYears(customValue);
                    }
                }
            }

            if (oldDate.Ticks != date.Ticks) {
                notificationShown = false;
            }

            // return remaining time 
            return fromDate - date;
        }

        public void showNotificationIfReady() {
            if (showNotification && !notificationShown) {
                if ((DateTime.Now - date).TotalMinutes == notificationMins) {
                    // TODO: show notification
                    notificationShown = true;
                }
            }
        }

        public int CompareTo(Reminder other) {
            return this.timeRemaining().TotalMilliseconds.CompareTo(other.timeRemaining().TotalMilliseconds);
        }
    }
}
