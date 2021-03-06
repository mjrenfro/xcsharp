﻿using NUnit.Framework;

public class CustomSetTest
{
    [Test]
    public void Sets_with_no_elements_are_empty()
    {
        var actual = new CustomSet<int>();
        Assert.That(actual.IsEmpty(), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Sets_with_elements_are_not_empty()
    {
        var actual = new CustomSet<int>(1);
        Assert.That(actual.IsEmpty(), Is.False);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Nothing_is_contained_in_an_empty_set()
    {
        var actual = new CustomSet<int>();
        Assert.That(actual.Contains(1), Is.False);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Detect_if_the_element_is_in_the_set()
    {
        var actual = new CustomSet<int>(new[] { 1, 2, 3 });
        Assert.That(actual.Contains(1), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Detect_if_the_element_is_not_in_the_set()
    {
        var actual = new CustomSet<int>(new[] { 1, 2, 3 });
        Assert.That(actual.Contains(4), Is.False);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Add_to_empty_set()
    {
        var actual = new CustomSet<int>().Insert(3);

        var expected = new CustomSet<int>(new[] { 3 });
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Add_to_non_empty_set()
    {
        var actual = new CustomSet<int>(new[] { 1, 2, 4 }).Insert(3);

        var expected = new CustomSet<int>(new[] { 1, 2, 3, 4 });
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Adding_an_existing_element_does_not_change_the_set()
    {
        var actual = new CustomSet<int>(new[] { 1, 2, 3 });
        actual.Insert(3);

        var expected = new CustomSet<int>(new[] { 1, 2, 3 });
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Empty_set_is_a_subset_of_another_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>();
        Assert.That(left.IsSubsetOf(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Empty_set_is_a_subset_of_non_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>(1);
        Assert.That(left.IsSubsetOf(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Non_empty_set_is_not_a_subset_of_empty_set()
    {
        var left = new CustomSet<int>(1);
        var right = new CustomSet<int>();
        Assert.That(left.IsSubsetOf(right), Is.False);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Set_is_a_subset_of_set_with_exact_same_elements()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3 });
        var right = new CustomSet<int>(new[] { 1, 2, 3 });
        Assert.That(left.IsSubsetOf(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Set_is_a_subset_of_larger_set_with_same_elements()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3 });
        var right = new CustomSet<int>(new[] { 4, 1, 2, 3 });
        Assert.That(left.IsSubsetOf(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Set_is_not_a_subset_of_set_that_does_not_contain_its_elements()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3 });
        var right = new CustomSet<int>(new[] { 4, 1, 3 });
        Assert.That(left.IsSubsetOf(right), Is.False);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void The_empty_set_is_disjoint_with_itself()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>();
        Assert.That(left.IsDisjointFrom(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Empty_set_is_disjoint_with_non_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>(1);
        Assert.That(left.IsDisjointFrom(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Non_empty_set_is_disjoint_with_empty_set()
    {
        var left = new CustomSet<int>(1);
        var right = new CustomSet<int>();
        Assert.That(left.IsDisjointFrom(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Sets_are_not_disjoint_if_they_share_an_element()
    {
        var left = new CustomSet<int>(new[] { 1, 2 });
        var right = new CustomSet<int>(new[] { 2, 3 });
        Assert.That(left.IsDisjointFrom(right), Is.False);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Sets_are_disjoint_if_they_share_no_elements()
    {
        var left = new CustomSet<int>(new[] { 1, 2 });
        var right = new CustomSet<int>(new[] { 3, 4 });
        Assert.That(left.IsDisjointFrom(right), Is.True);
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Intersection_of_two_empty_sets_is_an_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>();
        var expected = new CustomSet<int>();
        Assert.That(left.Intersection(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Intersection_of_an_empty_set_and_non_empty_set_is_an_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>(new[] { 3, 2, 5 });
        var expected = new CustomSet<int>();
        Assert.That(left.Intersection(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Intersection_of_a_non_empty_set_and_an_empty_set_is_an_empty_set()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3, 4 });
        var right = new CustomSet<int>();
        var expected = new CustomSet<int>();
        Assert.That(left.Intersection(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Intersection_of_two_sets_with_no_shared_elements_is_an_empty_set()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3 });
        var right = new CustomSet<int>(new[] { 4, 5, 6 });
        var expected = new CustomSet<int>();
        Assert.That(left.Intersection(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Intersection_of_two_sets_with_shared_elements_is_a_set_of_the_shared_elements()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3, 4 });
        var right = new CustomSet<int>(new[] { 3, 2, 5 });
        var expected = new CustomSet<int>(new[] { 2, 3 });
        Assert.That(left.Intersection(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Difference_of_two_empty_sets_is_an_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>();
        var expected = new CustomSet<int>();
        Assert.That(left.Difference(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Difference_of_an_empty_set_and_non_empty_set_is_an_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>(new[] { 3, 2, 5 });
        var expected = new CustomSet<int>();
        Assert.That(left.Difference(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Difference_of_a_non_empty_set_and_an_empty_set_is_an_empty_set()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3, 4 });
        var right = new CustomSet<int>();
        var expected = new CustomSet<int>(new[] { 1, 2, 3, 4 });
        Assert.That(left.Difference(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Difference_of_two_non_empty_sets_is_a_set_of_elements_that_are_only_in_the_first_set()
    {
        var left = new CustomSet<int>(new[] { 3, 2, 1 });
        var right = new CustomSet<int>(new[] { 2, 4 });
        var expected = new CustomSet<int>(new[] { 1, 3 });
        Assert.That(left.Difference(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Union_of_two_empty_sets_is_an_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>();
        var expected = new CustomSet<int>();
        Assert.That(left.Union(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Union_of_an_empty_set_and_non_empty_set_is_the_non_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>(new[] { 2 });
        var expected = new CustomSet<int>(new[] { 2 });
        Assert.That(left.Union(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Union_of_a_non_empty_set_and_empty_set_is_the_non_empty_set()
    {
        var left = new CustomSet<int>(new[] { 1, 3 });
        var right = new CustomSet<int>();
        var expected = new CustomSet<int>(new[] { 1, 3 });
        Assert.That(left.Union(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Union_of_non_empty_sets_contains_all_unique_elements()
    {
        var left = new CustomSet<int>(new[] { 1, 3 });
        var right = new CustomSet<int>(new[] { 2, 3 });
        var expected = new CustomSet<int>(new[] { 3, 2, 1 });
        Assert.That(left.Union(right), Is.EquivalentTo(expected));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Empty_sets_are_equal()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>();
        Assert.That(left, Is.EquivalentTo(right));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Empty_set_is_not_equal_to_non_empty_set()
    {
        var left = new CustomSet<int>();
        var right = new CustomSet<int>(new[] { 1, 2, 3 });
        Assert.That(left, Is.Not.EquivalentTo(right));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Non_empty_set_is_not_equal_to_empty_set()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3 });
        var right = new CustomSet<int>();
        Assert.That(left, Is.Not.EquivalentTo(right));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Sets_with_the_same_elements_are_equal()
    {
        var left = new CustomSet<int>(new[] { 1, 2 });
        var right = new CustomSet<int>(new[] { 2, 1 });
        Assert.That(left, Is.EquivalentTo(right));
    }

    [Ignore("Remove to run test")]
    [Test]
    public void Sets_with_different_elements_are_not_equal()
    {
        var left = new CustomSet<int>(new[] { 1, 2, 3 });
        var right = new CustomSet<int>(new[] { 1, 2, 4 });
        Assert.That(left, Is.Not.EquivalentTo(right));
    }
}