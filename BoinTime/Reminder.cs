using System;
using System.Windows.Forms;

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
        public bool notificationShown { get; set; }

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

        /// <summary>
        /// Gets time reaining between this.date and now
        /// </summary>
        public TimeSpan timeRemaining() {
            return timeRemaining(DateTime.Now);
        }

        /// <summary>
        /// Gets time reaining between this.date and fromDate
        /// </summary>
        public TimeSpan timeRemaining(DateTime fromDate) {
            var oldDate = new DateTime(date.Ticks); // copy this.date

            // while this.date has passed fromDate, set this.date to the next date based on this.type
            // ex: fromDate is 1/3/17 and we have a daily reminder that's date property is 1/1/17
            // if we just added a day to the date, it would still be in the past, so we add days until it isn't
            while (!expired && (date - fromDate).TotalMilliseconds <= 0) {
                if (type == ReminderType.once) {
                    expired = true;
                } else if (type == ReminderType.hourly) {
                    date = date.AddHours(1);
                } else if (type == ReminderType.daily) {
                    date = date.AddDays(1);
                } else if (type == ReminderType.weekly) {
                    date = date.AddDays(7);
                } else if (type == ReminderType.monthly) {
                    date = date.AddMonths(1);
                } else if (type == ReminderType.yearly) {
                    date = date.AddYears(1);
                } else { // custom (or 'every')
                    if (customType == CustomType.minutes) {
                        date = date.AddMinutes(customValue);
                    } else if (customType == CustomType.hours) {
                        date = date.AddHours(customValue);
                    } else if (customType == CustomType.days) {
                        date = date.AddDays(customValue);
                    } else if (customType == CustomType.weeks) {
                        date = date.AddDays(customValue * 7);
                    } else if (customType == CustomType.months) {
                        date = date.AddMonths(customValue);
                    } else if (customType == CustomType.years) {
                        date = date.AddYears(customValue);
                    }
                }
            }

            // if we reset the time, prime the notification
            if (oldDate.Ticks != date.Ticks) {
                notificationShown = false;
            }

            // return remaining time 
            return date - fromDate;
        }

        /// <summary>
        /// Formats the output of this.timeRemaining() ex: 2y\n37d\n
        /// </summary>
        public string timeRemainingPrettified() {
            return timeRemainingPrettified(DateTime.Now, 2);
        }

        /// <summary>
        /// Formats the output of this.timeRemaining(fromDate) ex: 2y\n37d\n
        /// </summary>
        public string timeRemainingPrettified(DateTime fromDate, int maxAppends) {
            var time = timeRemaining(fromDate);
            string prettyTime = "";
            int appends = 0;

            // years
            if (time.Days >= 365) {
                prettyTime += ((int)(time.Days / 365)).ToString() + "y\n";
                appends++;
            }

            // days
            if (time.Days > 0) {
                prettyTime += time.Days.ToString() + "d\n";
                if (++appends == maxAppends) {
                    return prettyTime;
                }
            }

            // hours
            if (time.Hours > 0) {
                prettyTime += time.Hours.ToString() + "h\n";
                if (++appends == maxAppends) {
                    return prettyTime;
                }
            }

            // minutes
            if (time.Minutes > 0) {
                prettyTime += time.Minutes.ToString() + "m\n";
                if (++appends == maxAppends) {
                    return prettyTime;
                }
            }

            // seconds
            if (time.Seconds > 0) {
                prettyTime += time.Seconds.ToString() + "s\n";
            }

            return prettyTime;
        }

        public void showNotificationIfReady() {
            // if we're scheduled to show a notification, we haven't already, and it's time to show one
            if (showNotification && !notificationShown && (date - DateTime.Now).TotalMinutes <= notificationMins) {
                // show the notification
                MainForm.instance.notification.ShowBalloonTip(
                    7000, // show for 7 seconds (Windows default)
                    "in " + timeRemaining().Minutes.ToString() + " minutes..." , // ex: in 5 minutes...
                    description + "\r\n(BoinTime)", // ex: take out the trash
                    ToolTipIcon.Info
                );

                notificationShown = true;
            }
        }

        public int CompareTo(Reminder other) {
            return this.timeRemaining().TotalMilliseconds.CompareTo(other.timeRemaining().TotalMilliseconds);
        }
    }
}
