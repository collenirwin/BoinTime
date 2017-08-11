using BoinMsgNS;
using System.Collections.Generic;

namespace BoinTime {
    public static class Reminders {
        public static List<Reminder> list { get; private set; }

        public static void init() {
            list = new List<Reminder>();

            if (!loadReminders()) {
                BoinMsg.show("Could not load your saved reminders.", "Error - BoinTime");
            }
        }

        public static bool loadReminders() {
            try {
                // read file into list
            } catch {
                return false;
            }

            return true;
        }

        public static bool saveReminders() {
            try {
                // save to a file
            } catch {
                return false;
            }

            return true;
        }

        public static void sort() {
            if (list != null) {
                list.Sort();
            }
        }
    }
}
