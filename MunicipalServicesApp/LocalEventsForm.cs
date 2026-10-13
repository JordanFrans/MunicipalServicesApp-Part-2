using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        // 1. Data Structure: Master Sorted List acting as a Priority Queue (Ordered by Date)
        private List<LocalEvent> masterEventQueue = new List<LocalEvent>();

        // 2. Data Structure: Dictionary for lightning-fast Category Lookups
        private Dictionary<string, List<LocalEvent>> categoryDictionary = new Dictionary<string, List<LocalEvent>>();

        // 3. Data Structure: Queue tracking user search categories for recommendations
        private Queue<string> searchPreferenceTracker = new Queue<string>();

        public LocalEventsForm()
        {
            InitializeComponent();
            SeedSampleData();
            DisplayAllEvents(masterEventQueue);
        }

        // Seeds mock municipal records into our advanced collections structure
        private void SeedSampleData()
        {
            AddEvent(new LocalEvent("Kimberley Clean-Up Campaign", "Join the community street sweeping project.", "Community", DateTime.Now.AddDays(2)));
            AddEvent(new LocalEvent("Power Grid Maintenance", "Scheduled electricity outages for substation upgrades.", "Utilities", DateTime.Now.AddDays(1)));
            AddEvent(new LocalEvent("Annual Heritage Festival", "Local food stalls, live traditional music, and cultural dances.", "Festivals", DateTime.Now.AddDays(5)));
            AddEvent(new LocalEvent("Water Sanitation Briefing", "Public town hall meeting regarding water purity reports.", "Utilities", DateTime.Now.AddDays(3)));
            AddEvent(new LocalEvent("Youth Sports Tournament", "Inter-district soccer and netball group matches.", "Community", DateTime.Now.AddDays(7)));
        }

        // Inserts elements safely into both our sorting engine and indexing dictionary
        private void AddEvent(LocalEvent newEvent)
        {
            // Insert into our master list and sort chronologically (Priority Queue behavior)
            masterEventQueue.Add(newEvent);
            masterEventQueue = masterEventQueue.OrderBy(e => e.EventDate).ToList();

            // Insert into category index dictionary
            if (!categoryDictionary.ContainsKey(newEvent.Category))
            {
                categoryDictionary[newEvent.Category] = new List<LocalEvent>();
            }
            categoryDictionary[newEvent.Category].Add(newEvent);
        }

        // Updates the primary data grid canvas view layout
        private void DisplayAllEvents(List<LocalEvent> eventList)
        {
            dgvEvents.Rows.Clear();
            foreach (var ev in eventList)
            {
                dgvEvents.Rows.Add(ev.Title, ev.Category, ev.EventDate.ToShortDateString(), ev.Description);
            }
        }

        // Search engine filter processing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var results = masterEventQueue.Where(ev =>
                ev.Title.ToLower().Contains(keyword) ||
                ev.Description.ToLower().Contains(keyword)
            ).ToList();

            // Log search pattern behavior for the automated recommendation engine tracker
            if (results.Any() && !string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string topMatchedCategory = results.First().Category;
                TrackUserPreference(topMatchedCategory);
            }

            DisplayAllEvents(results);
        }

        // Category combo-box filtering logic using dictionary lookups
        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategoryFilter.SelectedItem.ToString();

            if (selectedCategory == "All Categories")
            {
                DisplayAllEvents(masterEventQueue);
                return;
            }

            if (categoryDictionary.ContainsKey(selectedCategory))
            {
                TrackUserPreference(selectedCategory);
                DisplayAllEvents(categoryDictionary[selectedCategory]);
            }
            else
            {
                dgvEvents.Rows.Clear();
            }
        }

        // Tracks and trims historical preference sizes to form smart user recommendations
        private void TrackUserPreference(string category)
        {
            searchPreferenceTracker.Enqueue(category);
            if (searchPreferenceTracker.Count > 5) // Maintain a moving window of the last 5 operations
            {
                searchPreferenceTracker.Dequeue();
            }
            UpdateRecommendations();
        }

        // Scans interest history matrices to determine personalized notifications
        private void UpdateRecommendations()
        {
            if (!searchPreferenceTracker.Any()) return;

            // Determine user's most frequently queried category
            var favoriteCategory = searchPreferenceTracker
                .GroupBy(c => c)
                .OrderByDescending(g => g.Count())
                .First().Key;

            lblRecommendedHeader.Text = $"Recommended for You ({favoriteCategory}):";

            // Grab matched items excluding duplicates
            var recommendations = masterEventQueue
                .Where(ev => ev.Category == favoriteCategory)
                .Take(2)
                .ToList();

            lstRecommendations.Items.Clear();
            foreach (var rec in recommendations)
            {
                lstRecommendations.Items.Add($"{rec.Title} - ({rec.EventDate.ToShortDateString()})");
            }
        }
    }
}