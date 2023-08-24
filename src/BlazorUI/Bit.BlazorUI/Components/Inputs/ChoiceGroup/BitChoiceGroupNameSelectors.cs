﻿namespace Bit.BlazorUI;

public class BitChoiceGroupNameSelectors<TItem, TValue>
{
    /// <summary>
    /// The AriaLabel field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, string?> AriaLabel { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.AriaLabel));

    /// <summary>
    /// The Id field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, string?> Id { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.Id));

    /// <summary>
    /// The IsEnabled field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, bool> IsEnabled { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.IsEnabled));

    /// <summary>
    /// The IconName field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, string?> IconName { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.IconName));

    /// <summary>
    /// The ImageSrc field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, string?> ImageSrc { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.ImageSrc));

    /// <summary>
    /// The ImageAlt field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, string?> ImageAlt { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.ImageAlt));

    /// <summary>
    /// The ImageSize field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, BitSize?> ImageSize { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.ImageSize));

    /// <summary>
    /// The SelectedImageSrc field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, string?> SelectedImageSrc { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.SelectedImageSrc));

    /// <summary>
    /// The Text field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, string?> Text { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.Text));

    /// <summary>
    /// The Value field name and selector of the custom input class.
    /// </summary>
    public BitNameSelectorPair<TItem, TValue?> Value { get; set; } = new(nameof(BitChoiceGroupItem<TValue>.Value));
}