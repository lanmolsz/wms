<?php
use Symfony\Component\Form\Extension\Core\Type\FormType;
use Symfony\Component\Form\Extension\Core\Type\TextareaType;
use Symfony\Component\Form\Extension\Core\Type\TextType;

return $app['form.factory']->createBuilder(FormType::class, $data)
    ->add('id', TextType::class, [
        'required' => true,
        'label'    => 'Id',
    ])
    ->add('fieldType', TextType::class, [
        'required' => false,
        'label'    => 'FieldType',
    ])
    ->add('fieldLength', TextType::class, [
        'required' => false,
        'label'    => 'FieldLength',
    ])
    ->add('fieldCount', TextType::class, [
        'required' => false,
        'label'    => 'FieldCount',
    ])
    ->add('nameFormat', TextType::class, [
        'required' => false,
        'label'    => 'NameFormat',
    ])
    ->add('description', TextType::class, [
        'required' => false,
        'label'    => 'Description',
    ])
    ->add('active', TextType::class, [
        'required' => false,
        'label'    => 'Active',
    ])
    ->add('version', TextType::class, [
        'required' => false,
        'label'    => 'Version',
    ])
    ->add('createdBy', TextType::class, [
        'required' => false,
        'label'    => 'CreatedBy',
    ])
    ->add('createdAt', TextType::class, [
        'required' => false,
        'label'    => 'CreatedAt',
    ])
    ->add('updatedBy', TextType::class, [
        'required' => false,
        'label'    => 'UpdatedBy',
    ])
    ->add('updatedAt', TextType::class, [
        'required' => false,
        'label'    => 'UpdatedAt',
    ])
    ->getForm();
